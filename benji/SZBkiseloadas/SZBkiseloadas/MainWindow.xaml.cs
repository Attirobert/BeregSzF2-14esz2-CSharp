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
using SZBkiseloadas.MainWindowPages;

namespace SZBkiseloadas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContent.Children.Add(new Wallet());
            homeBtn.Tag = new Wallet();
            plusBtn.Tag = new Transfer();
            profilBtn.Tag = new Profil();
        }

        private void ButtonIndigoReset_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            for (int i = 0; i < Navigation.Children.Count; i++)
            {
                (((Navigation.Children[i] as UserControl).Content as Grid).Children[1] as Border).Visibility = Visibility.Collapsed;
            }

            UserControl Page =(UserControl)(sender as UserControl).Tag;
            MainContent.Children.Clear();
            MainContent.Children.Add(Page);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
