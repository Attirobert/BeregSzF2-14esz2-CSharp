using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixTranszform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Feltoltes();
        }
        private string strPlan = "Páratlan elemek összege: ";
        private string strFoatlo = "Főátló elemeinek összege: ";
        private string strSorok = "Sorok összege: ";
        private string strOszlopok = "Oszlopok összege: ";

        private int meret = 3;

        Random rnd = new Random();

        private void Feltoltes()
        {
            lblPlan.Text = strPlan;
            lblFoatlo.Text = strFoatlo;
            lblSorok.Text = strSorok;
            lblOszlopok.Text = strOszlopok;
        }

        private void transzponálásToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mniGeneral_Click(object sender, EventArgs e)
        {
            //int szam;
            dgvM.Rows.Clear();
            for (int i = 0; i < meret; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                for (int j = 0; j < meret; j++)
                {
                    //szam = rnd.Next(10) + 10;
                    DataGridViewCell dc = new DataGridViewTextBoxCell();
                    dc.Value = rnd.Next(10) + 10;
                    r.Cells.Add(dc);
                }
                dgvM.Rows.Add(r);
            }
        }

        private void mniParatlan_Click(object sender, EventArgs e)
        {
            int plan = 0, szam;

            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    szam = (int)dgvM.Rows[j].Cells[i].Value;
                    if (szam % 2 == 0) plan += szam;
                }
            }

            // Páratlan számok összegének kiíratása
        }

        private void mniFoatlo_Click(object sender, EventArgs e)
        {
            int p = 0;

            for (int i = 0; i < meret; i++)
            {
                p += (int)dgvM.Rows[i].Cells[i].Value;
            }

            // Főátló összegének kiíratása
        }

        private void mniSorok_Click(object sender, EventArgs e)
        {
            int plan = 0;

            for (int i = 0; i < meret; i++)
            {
                plan = 0;
                for (int j = 0; j < meret; j++)
                {
                    plan += (int)dgvM.Rows[i].Cells[j].Value;
                }

                // Sor összegének kiíratása
            }
        }

        private void mniOszlopok_Click(object sender, EventArgs e)
        {
            int plan = 0;

            for (int i = 0; i < meret; i++)
            {
                plan = 0;
                for (int j = 0; j < meret; j++)
                {
                    plan += (int)dgvM.Rows[j].Cells[i].Value;
                }

                // Oszlop összegének kiíratása
            }
        }

        private void mniTranszform_Click(object sender, EventArgs e)
        {
            int[,] tomb = new int[meret,meret];


            
        }
    }
}
