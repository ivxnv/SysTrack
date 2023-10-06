using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SysTrack.Views;
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
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Content = new LoginPage();
        }

        // Im Code-Behind von Ihrem Hauptfenster (z.B. MainWindow.xaml.cs)
        public void ShowLoginPage()
        {
            Content = new LoginPage();
        }

        public void ShowRegisterPage()
        {
            Content = new RegisterPage();
        }

    }
}
