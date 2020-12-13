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
    /// Interaction logic for TextBox.xaml
    /// </summary>
    public partial class TextBox : UserControl
    {
        public TextBox()
        {
            InitializeComponent();
        }


        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(TextBox), new PropertyMetadata(""));

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contentControl1.Visibility = (String.IsNullOrWhiteSpace(textBox1.Text.Trim())) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void contentControl1_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
