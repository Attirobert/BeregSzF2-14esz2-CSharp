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
    /// Interaction logic for DeleteAccount.xaml
    /// </summary>
    public partial class DeleteAccount : UserControl
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void Close_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((fiokTorlesWiondow as UserControl).Parent as Grid).Visibility = Visibility.Collapsed;
        }

        private void Nem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((fiokTorlesWiondow as UserControl).Parent as Grid).Visibility = Visibility.Collapsed;
        }

        private void igen_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            //TODO: törölni a fiókot
        }
    }
}
