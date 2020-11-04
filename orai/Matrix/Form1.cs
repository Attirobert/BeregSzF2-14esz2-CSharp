using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            AdatokFeltolt(Convert.ToInt32(nudSor.Value), Convert.ToInt32(nudOszlop.Value));
            EredmenyKiir(Convert.ToInt32(nudSor.Value), Convert.ToInt32(nudOszlop.Value));
        }

        private void AdatokFeltolt(int sor, int oszlop)
        {
            dgvMatrix.Columns.Clear();
            dgvMatrix.Rows.Clear();

            // Oszlopok deklarálása, fejlécek nullázása
            for (int i = 0; i < oszlop; i++)
            {
                dgvMatrix.Columns.Add(String.Empty, String.Empty);
                dgvMatrix.Columns[i].Width = 35;
            }

            // Sorok létrehozása
            for (int i = 0; i < sor; i++)
            {
                object[] intTomb = new object[oszlop];
                for (int j = 0; j < oszlop; j++)
                {
                    intTomb[j] = random.Next(sor * oszlop * 10) + 1;
                }
                dgvMatrix.Rows.Add(intTomb);
            }
        }

        private void EredmenyKiir(int sor, int oszlop)
        {
           
            int max = int.MinValue,
                min = int.MaxValue;

            int maxi = 0,
                maxj = 0,
                mini = 0,
                minj = 0;

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    if (Convert.ToInt32(dgvMatrix[j,i].Value) > max)
                    {
                        max = Convert.ToInt32(dgvMatrix[j, i].Value);
                        maxi = i+1;
                        maxj = j+1;
                    }

                    if ((Convert.ToInt32(dgvMatrix[j, i].Value) < min) &&
                        dgvMatrix[j, i].Value != null)
                    {
                        min = Convert.ToInt32(dgvMatrix[j, i].Value);
                        mini = i+1;
                        minj = j+1;
                    }
                }
            }

            rtbEredm.ResetText();
            rtbEredm.AppendText(String.Format("A legnagyobb elem: {0} {1}", 
                max, Environment.NewLine));
            rtbEredm.AppendText(String.Format("A legnagyobb elem indexe: [{0}, {1}] {2}",
                maxi, maxj, Environment.NewLine));
            rtbEredm.AppendText(String.Format("A legkisebb elem: {0} {1}",
                min, Environment.NewLine));
            rtbEredm.AppendText(String.Format("A legkisebb elem indexe: [{0}, {1}] {2}",
                mini, minj, Environment.NewLine));
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EredmenyKiir(dgvMatrix.Rows.Count, dgvMatrix.Columns.Count);
        }
    }
}
