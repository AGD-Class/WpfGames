using System.IO;
using System.Text.Json;

namespace RPG.Core
{
    /// <summary>
    /// 存档管理器（基础实现）
    /// </summary>
    public class SaveManager
    {
        private const string SaveFolder = "Resources/Saves";

        public static void Save<T>(T data, string filename)
        {
            Directory.CreateDirectory(SaveFolder);
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(SaveFolder, filename), json);
        }

        public static T? Load<T>(string filename)
        {
            var path = Path.Combine(SaveFolder, filename);
            if (!File.Exists(path)) return default;
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
