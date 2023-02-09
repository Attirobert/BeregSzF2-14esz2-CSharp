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
    /// Interaction logic for Transfer.xaml
    /// </summary>
    public partial class Transfer : UserControl
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void utalas_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            App.mainWindow.ertesitesek.Children.Clear();
            App.mainWindow.ertesitesek.Children.Add(new MainWindowPages.Notifications.Successful());
            App.mainWindow.ertesitesek.Visibility = Visibility.Visible;
            ;
        }
    }
}
