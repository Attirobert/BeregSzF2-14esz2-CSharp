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

namespace SZBkiseloadas.UserControls
{
    /// <summary>
    /// Interaction logic for ButtonHome.xaml
    /// </summary>
    public partial class ButtonHome : UserControl
    {
        public ButtonHome()
        {
            InitializeComponent();
        }

        private void homeBtn_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            indigo.Visibility = Visibility.Visible;
        }
    }
}
