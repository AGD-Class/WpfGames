namespace RPG.Models
{
    /// <summary>
    /// 地图格子基础定义（可扩展）
    /// </summary>
    public class MapTile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsWalkable { get; set; } = true;
    }
}
