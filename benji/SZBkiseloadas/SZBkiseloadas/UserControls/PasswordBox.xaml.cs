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
    /// Interaction logic for PasswordBox.xaml
    /// </summary>
    public partial class PasswordBox : UserControl
    {
        public PasswordBox()
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
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(PasswordBox), new PropertyMetadata(""));



        private void Password_TextChanged(object sender, RoutedEventArgs e)
        {
            contentControl1.Visibility = (String.IsNullOrWhiteSpace(textBox1.Password.Trim())) ? Visibility.Visible : Visibility.Collapsed;
        }


        private void eye_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (eyeOpen.Visibility==Visibility)
            {
                eyeOpen.Visibility = Visibility.Collapsed;
                eyeClose.Visibility = Visibility.Visible;
                contentControl2.Content = textBox1.Password;
                contentControl2.Visibility = Visibility.Visible;
            }
            else
            {
                eyeOpen.Visibility = Visibility.Visible;
                eyeClose.Visibility = Visibility.Collapsed;
                contentControl2.Visibility = Visibility.Collapsed;
            }
        }


        private void contentControl1_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox1.Focus();
        }
    }
}
