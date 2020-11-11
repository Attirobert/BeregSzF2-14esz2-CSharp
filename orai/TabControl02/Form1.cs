using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl02
{
    public partial class Form1 : Form
    {
        private Control ctlLap1;    // Bejárási sorrend szerint első elem

        public Form1()
        {
            InitializeComponent();
            ctlLap1 = TabElso(tbpAdatok);
            tbpAdatok.Focus();  // Induláskor az Adatok lapra nyitok
        }

        private Control TabElso(TabPage p)
        {   // A bejárási sor első elemének megkeresése
            Control r = p.Controls[0];
            for (int i = 0; i < p.Controls.Count-1; i++)
            {
                if ((p.Controls[i].TabIndex < p.Controls[i + 1].TabIndex) && p.Controls[i].TabStop)
                    r = p.Controls[i];
                else r = p.Controls[i+1];
            }
            return r;
        }

        private void Ellenoriz(object sender, EventArgs e)
        {   // Beviteli mezők ellenőrzése egy metódussal
            // A sender megadja, hogy melyik controllról van szó 
            TextBox a = (TextBox)sender;    // Típus kényszerítés, hogy a .Text tulajdonsághoz hozzá férjek
            Control b = (Control)sender;    // Típus kényszerítés, hogy a .SelectNextControl metódushoz hozzá férjek
            int res;
            if (int.TryParse(a.Text, out res))
                // Ha jó, akkor tovább léptet a bejárási sorban
                b.SelectNextControl(ActiveControl, true, true, true, true);
            else
            {
                // Ha nem, akkor hibaüzenet és vissza adja a fókuszt
                MessageBox.Show("Hibás adat!");
                a.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tényleg kilép?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                tbpAdatok.Focus();
            }

        }

        private void tbpAdatok_Enter(object sender, EventArgs e)
        {
            ctlLap1.Focus();
        }
    }
}
