using System;
using System.Text.RegularExpressions;

namespace SysTrack.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int RamSize { get; set; } // In Megabytes
        public double CpuFrequency { get; set; } // In Gigahertz
        public DateTime DeliveryDate { get; set; }
        public string CustomerName { get; set; }
        public bool IsFinanced { get; set; }
        public decimal PurchasePrice { get; set; } // Bei Barzahlung
        public decimal MonthlyRate { get; set; } // Bei Finanzierung
        public int FinancingTerm { get; set; } // Laufzeit in Monaten bei Finanzierung
        public decimal FinalPrice { get; set; } // Endpreis bei Finanzierung
        public string MacAddress { get; set; }

        // Standardkonstruktor
        public Computer() { }

        // Überladener Konstruktor für einfache Initialisierung
        public Computer(string productName, int ramSize, double cpuFrequency, DateTime deliveryDate, string customerName)
        {
            ProductName = productName;
            RamSize = ramSize;
            CpuFrequency = cpuFrequency;
            DeliveryDate = deliveryDate;
            CustomerName = customerName;
        }

        // Methode zur Überprüfung der Gültigkeit der MAC-Adresse
        public bool IsValidMacAddress()
        {
            var regex = new Regex(@"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$");
            return regex.IsMatch(MacAddress);
        }

        // Methode zum Überschreiben der ToString-Methode
        public override string ToString()
        {
            return $"{ProductName} - {RamSize}MB RAM, {CpuFrequency}GHz CPU, Delivered on {DeliveryDate.ToShortDateString()} to {CustomerName}";
        }

        // Methode zur Validierung des Computer-Objekts
        public bool IsValid()
        {
            // Hier könnten Sie weitere Validierungsregeln hinzufügen
            if (!string.IsNullOrEmpty(MacAddress) && !IsValidMacAddress())
            {
                return false;
            }
            return true;
        }
    }
}
