using System.Windows;
using RPG.Core;
using RPG.Views;

namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 初始化并切换到地图场景
            GameManager.Instance.Initialize(SceneHost);
            GameManager.Instance.ChangeScene(new MapView());
        }
    }
}