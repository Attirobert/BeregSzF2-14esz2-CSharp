using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzinek_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {
                lblSzin.BackColor = cd.Color;
                lblSzinkod.Text = cd.Color.ToString();
            }
        }

        private void btnKep_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbKep.SizeMode = PictureBoxSizeMode.CenterImage;
                pbKep.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnNyit_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
                tbxSzoveg.Text = File.ReadAllText(ofd.FileName);
        }

        private void btnMent_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog()==DialogResult.OK)
                File.WriteAllText(sf.FileName, tbxSzoveg.Text);
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            tbxSzoveg.Clear();
        }
    }
}
