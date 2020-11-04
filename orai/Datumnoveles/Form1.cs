using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datumnoveles
{

    public partial class Form1 : Form
    {
        int ev = 0;
        int honap = 0;
        int nap = 0;
        int ora = 0;
        int perc = 0;
        int masodperc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mtbPerces.Text = String.Format("{0}:{1}:{2}", dtpNaptar.Value.Hour, dtpNaptar.Value.Minute, dtpNaptar.Value.Second);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ev = Convert.ToInt32(numericUpDown1.Value + dtpNaptar.Value.Year);
            label1.Text = String.Format("{0}.", ev);
        }
    }
}
