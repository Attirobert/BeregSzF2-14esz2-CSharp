using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepekKorbe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBal_Click(object sender, EventArgs e)
        {
            Image s = label1.Image;
            label1.Image = label8.Image;
            label8.Image = label7.Image;
            label7.Image = label6.Image;
            label6.Image = label5.Image;
            label5.Image = label4.Image;
            label4.Image = label3.Image;
            label3.Image = label2.Image;
            label2.Image = s;
        }

        private void btnJobb_Click(object sender, EventArgs e)
        {
            Image s = label1.Image;
            label1.Image = label2.Image;
            label2.Image = label3.Image;
            label3.Image = label4.Image;
            label4.Image = label5.Image;
            label5.Image = label6.Image;
            label6.Image = label7.Image;
            label7.Image = label8.Image;
            label8.Image = s;
        }
    }
}
