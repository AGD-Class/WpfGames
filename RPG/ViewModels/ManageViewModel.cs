using System.Collections.ObjectModel;
using RPG.Models;

namespace RPG.ViewModels
{
    /// <summary>
    /// 经营视图模型
    /// </summary>
    public class ManageViewModel
    {
        public ObservableCollection<Building> Buildings { get; } = new ObservableCollection<Building>();
    }
}
