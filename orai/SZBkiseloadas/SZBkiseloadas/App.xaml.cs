using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SZBkiseloadas
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static FirstWindow firstWindow = new FirstWindow();
        public static MainWindow mainWindow = new MainWindow();
        public static RegistrationWindow registrationWindow = new RegistrationWindow();
        public static LoginWindow loginWindow = new LoginWindow();

        public App()
        {
            firstWindow.Show();
        }

    }
}
