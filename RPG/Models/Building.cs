namespace RPG.Models
{
    /// <summary>
    /// 经营建筑/设施数据结构（简易）
    /// </summary>
    public class Building
    {
        public string Name { get; set; } = "";
        public int Level { get; set; } = 1;
        public int IncomePerTurn { get; set; } = 0;
    }
}
