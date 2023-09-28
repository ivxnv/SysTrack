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
            // Hier könnten Sie die Computers-Liste aus einer Datenquelle befüllen
        }

        // Weitere Methoden und Eigenschaften zur Handhabung der Benutzerinteraktion
    }
}
