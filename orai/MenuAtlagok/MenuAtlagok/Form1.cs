using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuAtlagok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JoSzamok()
        {
            if (nud1.Value > 0 &&
                nud2.Value > 0 &&
                nud3.Value > 0) return true;
            else
            {
                MessageBox.Show("Három egész számot kérek! ", "Hiba...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void mniSzamtani_Click(object sender, EventArgs e)
        {
            if (JoSzamok())
            {
                lbxEredm.Items.Add("Számtani átlag: " + Math.Round((nud1.Value + nud2.Value + nud3.Value) / 3,4));
            }
        }

        private void mniMertani_Click(object sender, EventArgs e)
        {
            lbxEredm.Items.Add("Mértani átlag: " + Math.Round(Math.Pow((double)(nud1.Value * nud2.Value * nud3.Value), 1 / 3),4));
        }

        private void mniHarmonik_Click(object sender, EventArgs e)
        {
            lbxEredm.Items.Add("Harmonikus átlag: " + 
                           Math.Round((3 / (1 / (double)nud1.Value + 1 / (double)nud2.Value + 1 / (double)nud3.Value)),4)); 
        }

        private void mniLegnagyobb_Click(object sender, EventArgs e)
        {
            lbxEredm.Items.Add("A legnagyobb szám: " + Math.Max(nud1.Value, Math.Max(nud2.Value, nud3.Value)));
        }

        private void mniTorol_Click(object sender, EventArgs e)
        {
            nud1.Value = nud1.Minimum;
            nud2.Value = nud2.Minimum;
            nud3.Value = nud3.Minimum;
            lbxEredm.Items.Clear();
        }

        private void mniKilep_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
