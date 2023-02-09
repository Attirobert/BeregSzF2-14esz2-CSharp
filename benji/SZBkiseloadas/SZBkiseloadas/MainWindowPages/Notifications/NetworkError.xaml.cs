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
    /// Interaction logic for NetworkError.xaml
    /// </summary>
    public partial class NetworkError : UserControl
    {
        public NetworkError()
        {
            InitializeComponent();
        }

        private void Close_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((HalozatiHiba as UserControl).Parent as Grid).Visibility = Visibility.Collapsed;
        }
    }
}
