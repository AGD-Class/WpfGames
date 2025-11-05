using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows.Input;
using RPG.Models;

namespace RPG.Views
{
    /// <summary>
    /// 地图视图：内置简单的WASD移动Demo（使用DispatcherTimer模拟主循环）
    /// </summary>
    public partial class MapView : UserControl
    {
        private readonly DispatcherTimer _timer = new DispatcherTimer();
        private readonly Character _player = new Character();

        public MapView()
        {
            InitializeComponent();
            Loaded += (s, e) => { GameCanvas.Focus(); }; // 确保接收键盘输入

            _timer.Interval = TimeSpan.FromMilliseconds(33); // 约30FPS
            _timer.Tick += OnUpdate;
            _timer.Start();
        }

        private void OnUpdate(object? sender, EventArgs e)
        {
            double speed = 4; // 每帧移动像素
            double x = Canvas.GetLeft(PlayerImage);
            double y = Canvas.GetTop(PlayerImage);

            if (Core.InputManager.IsKeyDown(Key.W) || Core.InputManager.IsKeyDown(Key.Up)) y -= speed;
            if (Core.InputManager.IsKeyDown(Key.S) || Core.InputManager.IsKeyDown(Key.Down)) y += speed;
            if (Core.InputManager.IsKeyDown(Key.A) || Core.InputManager.IsKeyDown(Key.Left)) x -= speed;
            if (Core.InputManager.IsKeyDown(Key.D) || Core.InputManager.IsKeyDown(Key.Right)) x += speed;

            // 限制在画布内（假设背景1280x720）
            x = Math.Clamp(x, 0, Math.Max(0, GameCanvas.ActualWidth - PlayerImage.Width));
            y = Math.Clamp(y, 0, Math.Max(0, GameCanvas.ActualHeight - PlayerImage.Height));

            Canvas.SetLeft(PlayerImage, x);
            Canvas.SetTop(PlayerImage, y);
        }
    }
}
