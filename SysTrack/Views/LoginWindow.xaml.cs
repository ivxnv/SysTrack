using System;
using System.Windows;

namespace SysTrack.Views
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, RoutedEventArgs e)
        {
            // Hier kommt Ihre Anmeldeüberprüfungslogik
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Anmeldeinformationen überprüfen
            // Beispiel (bitte durch Ihre eigentliche Anmeldeüberprüfungslogik ersetzen):
            if (IsValidLogin(username, password))
            {
                // Anmeldung erfolgreich, Hauptfenster öffnen oder was auch immer Sie als Nächstes tun möchten
            }
            else
            {
                // Anmeldung fehlgeschlagen, Benutzer informieren
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            // Hier überprüfen Sie die Anmeldeinformationen gegen Ihre Datenbank oder eine andere Quelle.
            // Dies ist nur ein Platzhalter und sollte durch Ihre eigentliche Logik ersetzt werden.
            return username == "admin" && password == "password"; // Beispielüberprüfung, bitte ändern!
        }
    }
}
