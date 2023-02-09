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
    /// Interaction logic for PaymentHitoryItem.xaml
    /// </summary>
    public partial class PaymentHitoryItem : UserControl
    {
        public PaymentHitoryItem()
        {
            InitializeComponent();
        }


        public string NameOfUser
        {
            get { return (string)GetValue(NameOfUserProperty); }
            set { SetValue(NameOfUserProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NameOfUser.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameOfUserProperty =
            DependencyProperty.Register("NameOfUser", typeof(string), typeof(PaymentHitoryItem), new PropertyMetadata("Basz Tamás"));



        public string Value
        {
            get { return (string)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(string), typeof(PaymentHitoryItem), new PropertyMetadata("-200"));



        public string Date
        {
            get { return (string)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Date.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(string), typeof(PaymentHitoryItem), new PropertyMetadata("2020.11.12 17:30"));


    }
}
