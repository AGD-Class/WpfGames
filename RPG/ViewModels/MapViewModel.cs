using System.Collections.ObjectModel;
using RPG.Models;

namespace RPG.ViewModels
{
    /// <summary>
    /// 地图视图模型
    /// </summary>
    public class MapViewModel
    {
        public ObservableCollection<MapTile> Tiles { get; } = new ObservableCollection<MapTile>();

        public MapViewModel()
        {
            // 初始化示例地图（可扩展为读取JSON地图）
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    Tiles.Add(new MapTile { X = x, Y = y, IsWalkable = true });
                }
            }
        }
    }
}
