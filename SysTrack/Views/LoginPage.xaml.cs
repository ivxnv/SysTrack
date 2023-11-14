using System;
using System.Windows;
using System.Windows.Controls;

namespace SysTrack.Views
{
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (IsValidLogin(username, password))
            {
                (Application.Current.MainWindow as MainWindow).Content = new ComputerView();
            }
            else
            {
    
            }
        }

        private void OnRegisterClicked(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).ShowRegisterPage();
        }


        private bool IsValidLogin(string username, string password)
        {
            return username == "admin" && password == "root";
        }
    }
}
