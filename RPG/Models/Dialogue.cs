using System.Collections.Generic;

namespace RPG.Models
{
    /// <summary>
    /// 对话脚本结构（示例）
    /// </summary>
    public class DialogueLine
    {
        public string Speaker { get; set; } = "";
        public string Text { get; set; } = "";
        public List<string>? Options { get; set; }
    }
}
