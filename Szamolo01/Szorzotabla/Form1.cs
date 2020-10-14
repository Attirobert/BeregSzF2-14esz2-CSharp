using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        private int szeles = 35;
        private int keret = 50;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaEpit(10, 10);
            Sorsol(dgvSzorzo);
        }

        private void TablaEpit(int sor, int oszlop)
        {
            dgvSzorzo.Columns.Clear();
            dgvSzorzo.Rows.Clear();
            dgvSzorzo.Width = szeles * oszlop + keret;

            for (int i = 0; i < oszlop; i++)
            {
                dgvSzorzo.Columns.Add(String.Empty, String.Empty);
                dgvSzorzo.Columns[i].Width = szeles;
            }

            for (int i = 0; i < sor; i++)
            {
                object[] intSor = new object[oszlop];
                dgvSzorzo.Rows.Add(intSor);
            }

            for (int i = 1; i < oszlop; i++)
            {
                dgvSzorzo[0, i].Value = i;
                dgvSzorzo[0, i].Style.Font = new Font(dgvSzorzo.Font, FontStyle.Bold);
            }

            for (int i = 1; i < oszlop; i++)
            {
                dgvSzorzo[i,0].Value = i;
                dgvSzorzo[i,0].Style.Font = new Font(dgvSzorzo.Font, FontStyle.Bold);
            }

        }

        private void Sorsol(DataGridView dgv)
        {
            int sorok = dgv.Rows.Count -2;
            int oszlopok = dgv.Columns.Count -2;

            int aktSor, aktOszlop;
            do
            {
                aktSor = random.Next(sorok) + 1;
                aktOszlop = random.Next(oszlopok) + 1;

            } while (dgv[aktSor, aktOszlop].Value != null);

            dgv[0, aktOszlop].Style.BackColor =
                dgv[aktSor, 0].Style.BackColor = Color.AliceBlue;
        }

        private void dgvSzorzo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Ellenoriz(dgvSzorzo, e.RowIndex, e.ColumnIndex);
        }

        private void Ellenoriz(DataGridView dgv, int sor, int oszlop)
        {
            if ((int)dgvSzorzo[sor, 0].Value * (int)dgvSzorzo[0, oszlop].Value != (int)dgvSzorzo[sor, oszlop].Value)
            {
                dgvSzorzo[sor, oszlop].Style.BackColor = Color.Red;
            }
            else
            {
                dgvSzorzo[sor, oszlop].Style.BackColor = Color.Green;
            }
        }
    }
}
