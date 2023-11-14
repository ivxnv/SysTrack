using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysTrack
{
    /// <summary>
    /// Interaktionslogik für RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void OnRegisterClicked(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string repeatPassword = RepeatPasswordBox.Password;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }

            if (password != repeatPassword)
            {
                MessageBox.Show("Die Passwörter stimmen nicht überein.");
                return;
            }
            RegisterUser(username, password);
        }

        private void OnLoginClicked(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ShowLoginPage();
        }

        private void RegisterUser(string username, string password)
        {
            MessageBox.Show("Registrierung erfolgreich!");
        }
    }
}
