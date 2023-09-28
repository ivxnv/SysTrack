using System;
using System.Collections.Generic;

namespace SysTrack.Models
{
    public class Rechnung
    {
        public string RechnungsNummer { get; set; }
        public DateTime RechnungsDatum { get; set; }
        public Kunde Kunde { get; set; }
        public List<Computer> GekaufteComputer { get; set; }

        // Standardkonstruktor
        public Rechnung()
        {
            GekaufteComputer = new List<Computer>();  // Initialisierung der GekaufteComputer-Liste
        }

        // Überladener Konstruktor für einfache Initialisierung
        public Rechnung(string rechnungsNummer, DateTime rechnungsDatum, Kunde kunde)
        {
            RechnungsNummer = rechnungsNummer;
            RechnungsDatum = rechnungsDatum;
            Kunde = kunde;
            GekaufteComputer = new List<Computer>();  // Initialisierung der GekaufteComputer-Liste
        }

        // Methode zur Hinzufügung eines Computers zur Rechnung
        public void AddComputer(Computer computer)
        {
            GekaufteComputer.Add(computer);
        }

        // Methode zur Berechnung des Gesamtbetrags der Rechnung
        public decimal BerechneGesamtbetrag()
        {
            decimal gesamtbetrag = 0;
            foreach (var computer in GekaufteComputer)
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
            return $"Rechnung: {RechnungsNummer}, Datum: {RechnungsDatum.ToShortDateString()}, Kunde: {Kunde.CustomerName}, Gesamtbetrag: {BerechneGesamtbetrag()}";
        }
    }
}
