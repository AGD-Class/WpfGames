using System.Windows.Controls;

namespace RPG.Core
{
    /// <summary>
    /// 全局游戏管理器，负责场景切换与全局状态管理
    /// </summary>
    public class GameManager
    {
        private static GameManager? _instance;
        public static GameManager Instance => _instance ??= new GameManager();

        private ContentControl? _sceneHost;

        public void Initialize(ContentControl host)
        {
            _sceneHost = host;
        }

        public void ChangeScene(UserControl newScene)
        {
            if (_sceneHost != null)
            {
                _sceneHost.Content = newScene;
            }
        }
    }
}
