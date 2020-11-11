using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Buttom_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(BekertSzam.Value);
            Generate(n);
            Skalaris(Matrix1,Matrix2, n);

        }
        private void Generate(int n)
        {

            Matrix1.Columns.Clear();
            Matrix1.Rows.Clear();
            Matrix2.Columns.Clear();
            Matrix2.Rows.Clear();

            for (int i = 0; i < n; i++)
            {
                Matrix1.Columns.Add(String.Empty, String.Empty);
                Matrix1.Columns[i].Width = 30;
            }
            for (int i = 0; i < n; i++)
            {
                Matrix2.Columns.Add(String.Empty, String.Empty);
                Matrix2.Columns[i].Width = 30;
            }

            for (int i = 0; i < n; i++)
            {
                object[] MatrixT = new object[n];
                for (int y = 0; y < n; y++)
                {
                    MatrixT[y] = rnd.Next(-200, 201);
                }
                Matrix1.Rows.Add(MatrixT);
            }

            for (int i = 0; i < n; i++)
            {
                object[] MatrixT2 = new object[n];
                for (int y = 0; y < n; y++)
                {
                    MatrixT2[y] = rnd.Next(-200,201);
                }
                Matrix2.Rows.Add(MatrixT2);
            }
        }
        private void Skalaris(DataGridView Matrix1, DataGridView Matrix2, int n)
        {
            int[,] MatrixTomb1 = new int[n, n];
            int[,] MatrixTomb2 = new int[n, n];

            int szam = 0;
            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y <n; y++)
                {
                    szam = Convert.ToInt32(Matrix1[i, y].Value);
                    MatrixTomb1[i, y] = szam;
                }
            }

            int szam2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    szam2 = Convert.ToInt32(Matrix1[i, y].Value);
                    MatrixTomb2[i, y] = szam;
                }
            }

            int[] osszeg = new int[n];
            int a = 0;
            for (int i = 0; i <n; i++)
            {
                for (int y = 0; y < n; y++)
                {
                    a = MatrixTomb1[i, y] * MatrixTomb2[i, y];
                    osszeg[i] = a;
                }
            }

            int result = 0;
            for (int i = 0; i < osszeg.Length; i++)
            {
                result += osszeg[i];
            }


            if (result > 0)
            {
                Eredmeny.Text = Convert.ToString(result);
                Eredmeny.ForeColor = Color.Blue;
            }
            else
            {
                Eredmeny.Text = Convert.ToString(result);
                Eredmeny.ForeColor = Color.Red;
            }
        }
    }
}
