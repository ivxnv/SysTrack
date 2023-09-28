using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SysTrack.Models
{
    public class Kunde
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Computer> Computers { get; set; }

        // Standardkonstruktor
        public Kunde()
        {
            Computers = new List<Computer>();  // Initialisierung der Computers-Liste
        }

        // Überladener Konstruktor für einfache Initialisierung
        public Kunde(string customerName, string address, string email, string phoneNumber)
        {
            CustomerName = customerName;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Computers = new List<Computer>();  // Initialisierung der Computers-Liste
        }

        // Methode zur Überprüfung der Gültigkeit der E-Mail-Adresse
        public bool IsValidEmail()
        {
            var regex = new Regex(@"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");
            return regex.IsMatch(Email);
        }

        // Methode zur Hinzufügung eines Computers zur Liste
        public void AddComputer(Computer computer)
        {
            Computers.Add(computer);
        }

        // Methode zum Überschreiben der ToString-Methode
        public override string ToString()
        {
            return $"{CustomerName}, {Address}, {Email}, {PhoneNumber}, Owns {Computers.Count} computers";
        }
    }
}
