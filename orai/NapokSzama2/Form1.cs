using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NapokSzama2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Szamit(object sender, DateRangeEventArgs e)
        {

            if (mcZaro.SelectionStart.CompareTo(mcKezdo.SelectionStart) < 0)
            {
                lblEredm.Text = "A kezdő dátum nagyobb mint a záró dátum!";
            }
            else
            {
                lblEredm.Text = String.Format("Az eltelt napok száma: {0}",
                    mcZaro.SelectionStart.Subtract(mcKezdo.SelectionStart).Days);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
