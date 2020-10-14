using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixDoga
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        private int min = -99; // A generált legkisebb szám
        private int max = 99; // A generált legnagyobb szám
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            MatrixGen(Convert.ToInt32(nudN.Value), dgvA);
            MatrixGen(Convert.ToInt32(nudN.Value), dgvB);
            Kiir(lblSkalar, lblSkalarFord, lblAtlo, lblAtloFel);
        }

        private void MatrixGen(int meret, DataGridView matrix)
        {
            // Mátrix kiürítése
            matrix.Rows.Clear();
            matrix.Columns.Clear();

            // Oszlopok deklarálása, fejlécek nullázása
            for (int i = 0; i < meret; i++)
            {
                matrix.Columns.Add(String.Empty, String.Empty);
                matrix.Columns[i].Width = 35;
            }

            // Sorok létrehozása
            for (int i = 0; i < meret; i++)
            {
                object[] intTomb = new object[meret];
                for (int j = 0; j < meret; j++)
                {
                    intTomb[j] = rnd.Next(min, max) + 1;
                }
                matrix.Rows.Add(intTomb);
            }

        }

        private void Kiir(Label lblS, Label lblSf, Label lblAo, Label lblAf)
        {
            // Label kiürítése
            lblS.Text =
                lblSf.Text =
                lblAo.Text =
                lblAf.Text = String.Empty;

            int w = 0;

            // Skalár szorzat
            w = Skalar(dgvA, dgvB);
            lblS.Text = String.Format("A két mátrix skaláris szorzata: {0} {1}", 
                w, Environment.NewLine);
            lblS.ForeColor = (w < 0) ? Color.Red : Color.Blue;

            // Fordított skalár szorzat
            w = SkalarFord(dgvA, dgvB);
            lblSf.Text += String.Format("A két mátrix fordított skaláris szorzata: {0} {1}",
                w, Environment.NewLine);
            lblSf.ForeColor = (w < 0) ? Color.Red : Color.Blue;

            // Átlóösszegek különbsége
            w = Atloosszeg(dgvA, dgvB);
            lblAo.Text += String.Format("A két mátrix átlóösszegének különbsége: {0} {1}",
                w, Environment.NewLine);
            lblAo.ForeColor = (w < 0) ? Color.Red : Color.Blue;

            // Átlók feletti összeg
            w = AtlokFelett(dgvA);
            lblAf.Text += String.Format("Az első mátrix átlói feletti összege: {0} {1}",
                w, Environment.NewLine);
            lblAf.ForeColor = (w < 0) ? Color.Red : Color.Blue;
        }

        private int Skalar(DataGridView dgva, DataGridView dgvb)
        {
            // Kihasználjuk, hogy négyzetes és azonos méretű mátrixokról van szó
            int m = dgva.Columns.Count;
            int sum = 0;    // A halmozáshoz

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += Convert.ToInt32(dgva[i, j].Value) * Convert.ToInt32(dgvb[i, j].Value);
                }
            }

            return sum;
        }

        private int SkalarFord(DataGridView dgva, DataGridView dgvb)
        {
            // Kihasználjuk, hogy négyzetes és azonos méretű mátrixokról van szó
            int m = dgva.Columns.Count;
            int sum = 0;    // A halmozáshoz

            for (int i = 0; i < m; i++)
            {
                for (int j = m-1; j >= 0; j--)
                {
                    sum += Convert.ToInt32(dgva[i, j].Value) * Convert.ToInt32(dgvb[i, j].Value);
                }
            }

            return sum;
        }
        private int Atloosszeg(DataGridView dgva, DataGridView dgvb)
        {
            // Kihasználjuk, hogy négyzetes és azonos méretű mátrixokról van szó
            int m = dgva.Columns.Count;
            int sum = 0;    // A halmozáshoz
            int ind = 0;    // Középső index

            for (int i = 0; i < m; i++)
            {
                    sum += Convert.ToInt32(dgva[i,i].Value)
                        + Convert.ToInt32(dgva[m-1-i,m-1-i].Value)
                        - Convert.ToInt32(dgvb[i, i].Value)
                        - Convert.ToInt32(dgvb[m - 1 - i, m - 1 - i].Value);

                // Ha m páratlan, akkor a középső elemek kétszer lettek figyelembe véve
                if (m % 2 > 0)
                {
                    ind = m / 2 + 1;
                    sum += Convert.ToInt32(dgvb[ind, ind].Value)
                        - Convert.ToInt32(dgva[ind, ind].Value);
                }
            }

            return sum;
        }

        private int AtlokFelett(DataGridView dgv)
        {
            int sum = 0;
            int oszlopok = dgv.Columns.Count - 2;
            int sorok = oszlopok / 2 - 1;
            int i = 0;  // Sor index
            int j = 1;  // Oszlop index
            while (i <= sorok)
            {
                while (j <= oszlopok)
                {
                    sum = Convert.ToInt32(dgv[i, j].Value);
                    j++;
                    oszlopok--;
                }

                i++;
            }

            return sum;
        }

    }
}
