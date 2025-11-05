using System.Windows.Input;

namespace RPG.Core
{
    /// <summary>
    /// 简单键盘输入管理器（静态封装）
    /// </summary>
    public static class InputManager
    {
        public static bool IsKeyDown(Key key) => Keyboard.IsKeyDown(key);
    }
}
