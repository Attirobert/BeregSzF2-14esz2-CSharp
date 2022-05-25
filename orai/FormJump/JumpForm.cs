using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 19.1. feladat I [Form sarokba igazítása gombnyomásra] Készíts WindowsForm
alkalmazást, mely a képernyő 4 sarkába ugorhat. Legyen rajta 4 button, amelyre kattintva
a form – a feliratának megfelelő – sarokba ugrik.

Segítség a megoldáshoz: Figyeljünk arra, hogy ne adjuk meg előre a lehetséges felbontás
értékeit, helyette használjuk a Screen.PrimeryScreen objektum Bounds tulajdonságait.
 */
namespace FormJump
{
    public partial class JumpForm : Form
    {
        public JumpForm()
        {
            InitializeComponent();
        }

        private void btnBalFel_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void btnJobbFel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void btnBalLe_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void btnJobbLe_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}
