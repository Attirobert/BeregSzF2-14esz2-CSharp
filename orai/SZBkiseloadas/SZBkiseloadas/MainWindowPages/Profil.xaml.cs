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

namespace SZBkiseloadas.MainWindowPages
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : UserControl
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void NevModositas_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((profilMain as UserControl).Parent as Grid).Children.Add(new MainWindowPages.ProfilSubPages.NevModositas());
            ((profilMain as UserControl).Parent as Grid).Children.RemoveAt(0);
        }

        private void JelszoModositas_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((profilMain as UserControl).Parent as Grid).Children.Add(new MainWindowPages.ProfilSubPages.JelszoModositas());
            ((profilMain as UserControl).Parent as Grid).Children.RemoveAt(0);
        }

        private void FiokTorlese_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            App.mainWindow.ertesitesek.Children.Clear();
            App.mainWindow.ertesitesek.Children.Add(new MainWindowPages.Notifications.DeleteAccount());
            App.mainWindow.ertesitesek.Visibility = Visibility.Visible;
        }

        private void Kijelentkezés_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            App.mainWindow.ertesitesek.Children.Clear();
            App.mainWindow.ertesitesek.Children.Add(new MainWindowPages.Notifications.SignOut());
            App.mainWindow.ertesitesek.Visibility = Visibility.Visible;
        }
    }
}
