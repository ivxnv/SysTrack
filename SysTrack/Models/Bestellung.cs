using System;
using System.Collections.Generic;

namespace SysTrack.Models
{
    public class Bestellung
    {
        public string BestellNummer { get; set; }
        public DateTime BestellDatum { get; set; }
        public Kunde Kunde { get; set; }
        public List<Computer> BestellteComputer { get; set; }

        // Standardkonstruktor
        public Bestellung()
        {
            BestellteComputer = new List<Computer>();  // Initialisierung der BestellteComputer-Liste
        }

        // Überladener Konstruktor für einfache Initialisierung
        public Bestellung(string bestellNummer, DateTime bestellDatum, Kunde kunde)
        {
            BestellNummer = bestellNummer;
            BestellDatum = bestellDatum;
            Kunde = kunde;
            BestellteComputer = new List<Computer>();  // Initialisierung der BestellteComputer-Liste
        }

        // Methode zur Hinzufügung eines Computers zur Bestellung
        public void AddComputer(Computer computer)
        {
            BestellteComputer.Add(computer);
        }

        // Methode zur Berechnung des Gesamtbetrags der Bestellung
        public decimal BerechneGesamtbetrag()
        {
            decimal gesamtbetrag = 0;
            foreach (var computer in BestellteComputer)
            {
                // Hier nehmen wir an, dass der Kaufpreis verwendet wird.
                // Falls die Finanzierung genutzt wird, müssen Sie die Logik entsprechend anpassen.
                gesamtbetrag += computer.PurchasePrice;
            }
            return gesamtbetrag;
        }

        // Methode zum Überschreiben der ToString-Methode
        public override string ToString()
        {
            return $"Bestellung: {BestellNummer}, Datum: {BestellDatum.ToShortDateString()}, Kunde: {Kunde.CustomerName}, Gesamtbetrag: {BerechneGesamtbetrag()}";
        }
    }
}
