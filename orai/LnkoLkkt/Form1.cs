using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LnkoLkkt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzamolj_Click(object sender, EventArgs e)
        {
            Ellenorzes();
        }

        private void Ellenorzes()
        {
            int a, b;

            // Input ellenörzött beolvasása
            if (!int.TryParse(tbxA.Text, out a))
            {
                MessageBox.Show("Nem számot adott meg");
                tbxA.Text = String.Empty;
                tbxA.Focus();
                return;
            }

            if (!int.TryParse(tbxB.Text, out b))
            {
                MessageBox.Show("Nem számot adott meg");
                tbxB.Text = String.Empty;
                tbxB.Focus();
                return;
            }

            if (rbLnko.Checked)
            {
                MessageBox.Show(String.Format("A két szám legnagyobb közös osztója: {0}", Lnko(a, b)));
            }

            if (rbLkkt.Checked)
            {
                MessageBox.Show(String.Format("A két szám legkisebb közös többszöröse: {0}", (a * b) / Lnko(a, b)));
            }
        }

        private int Lnko(int a, int b)
        {
            if (a == 0) return b;

            if (b == 0) return a;

            if (a > b) return Lnko(a % b, b);
            else return Lnko(a, b % a);
        }
    }
}
