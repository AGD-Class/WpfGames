namespace RPG.Models
{
    /// <summary>
    /// 角色数据结构
    /// </summary>
    public class Character
    {
        public string Name { get; set; } = "主角";
        // 资源引用路径
        public string ImagePath { get; set; } = "/Resources/Characters/MainCharacter.jpg";
        // 地图像素坐标
        public int X { get; set; } = 320;
        public int Y { get; set; } = 320;

        public string Description { get; set; } = "这是游戏中的主角，勇敢而坚韧，准备踏上冒险之旅。";

    }
}
