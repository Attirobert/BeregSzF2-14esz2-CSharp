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
    /// Interaction logic for NumPad.xaml
    /// </summary>
    public partial class NumPad : UserControl
    {
        public NumPad()
        {
            InitializeComponent();
        }

        private void minus_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Value.Content = (Convert.ToInt32(Value.Content) - 2 >= 0) ? Convert.ToInt32(Value.Content) - 20 : Convert.ToInt32(Value.Content);
        }

        private void plus_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Value.Content = Convert.ToInt32(Value.Content) + 20;
        }
    }
}
