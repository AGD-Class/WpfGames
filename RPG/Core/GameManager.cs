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
        public GameState CurrentState { get; private set; }

        //private StoryManager _storyManager;
        //private BattleManager _battleManager;

        public void StartGame()
        {
            // 加载初始剧情
            //var openingScenes = LoadOpeningStory();
            //_storyManager = new StoryManager(openingScenes);
            //_storyManager.OnStoryCompleted += OnOpeningStoryCompleted;
            //_storyManager.StartStory();
            CurrentState = GameState.Story;
        }
        private void OnOpeningStoryCompleted()
        {
            // 剧情结束，开始战斗
            StartBattle();
        }

        private void StartBattle()
        {
            CurrentState = GameState.Battle;
            //_battleManager = new BattleManager();
            // 初始化战场角色...
            // 监听战斗结束事件
            // _battleManager.OnBattleCompleted += OnBattleCompleted;
        }

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

    public enum GameState
    {
        Story,
        Battle,
        Menu
    }
}
