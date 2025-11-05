using System.Collections.ObjectModel;
using RPG.Models;

namespace RPG.ViewModels
{
    /// <summary>
    /// 对话视图模型
    /// </summary>
    public class DialogueViewModel
    {
        public ObservableCollection<DialogueLine> Lines { get; } = new ObservableCollection<DialogueLine>();
    }
}
