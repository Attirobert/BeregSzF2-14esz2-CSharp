using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jegykalkulator
{
    public partial class Form1 : Form
    {
        int szam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //polimorfizmus : több alakúság
            
            szam += Convert.ToInt32(((Button)sender).Text);
            label1.Text=szam.ToString();

        }
    }
}
