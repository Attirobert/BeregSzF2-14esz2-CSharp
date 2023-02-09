using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SZBkiseloadas.MainWindowPages.Notifications
{
    /// <summary>
    /// Interaction logic for SignOut.xaml
    /// </summary>
    public partial class SignOut : UserControl
    {
        public SignOut()
        {
            InitializeComponent();
        }

        private void igen_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            App.firstWindow.Show();
            App.mainWindow.Close();
        }

        private void Nem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((kijelentkezesWiondow as UserControl).Parent as Grid).Visibility = Visibility.Collapsed;
        }

        private void Close_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((kijelentkezesWiondow as UserControl).Parent as Grid).Visibility = Visibility.Collapsed;
        }
    }
}
