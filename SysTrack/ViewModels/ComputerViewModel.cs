using SysTrack.Models;
using System.Collections.ObjectModel;

namespace SysTrack.ViewModels
{
    public class ComputerViewModel
    {
        public ObservableCollection<Computer> Computers { get; set; }

        public ComputerViewModel()
        {
            Computers = new ObservableCollection<Computer>();
        }
    }
}
