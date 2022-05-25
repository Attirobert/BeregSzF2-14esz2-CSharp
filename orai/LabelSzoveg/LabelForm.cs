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
 19.2. feladat I [Szöveg igazítása] Készíts WindowsForm alkalmazást, amely a label
komponens szövegigazításait demonstrálja. A formon egy label legyen található, ami a
form egész területét elfoglalja. A label egyes részeire kattintva változtathatjuk a szöveg
igazítását.
1
Segítség a megoldáshoz: A 9 külön lehetőség miatt ne hozzunk létre komponenseket, és írjunk
külön eseménykezelőket. Helyette képzeletben osszuk fel a form területét, és a kattintásokkor
ez alapján állítsuk be a label komponens szövegének elrendezését.
 */
namespace LabelSzoveg
{
    public partial class LabelForm : Form
    {
        public LabelForm()
        {
            InitializeComponent();
        }

        private void LabelForm_Load(object sender, EventArgs e)
        {
            lblFull.Text = "Kattints a képernyőn valahova!";
        }

        private void lblFull_MouseClick(object sender, MouseEventArgs e)
        {
            int o = (int)e.X / (lblFull.Width / 3);     // Hanyadik oszlopba kattintottunk
            int s = (int)e.Y / (lblFull.Height / 3);    // Hanyadik sorba kattintottunk

            // Sorszámozzuk a területeket: (s * 3 + o)
            switch (s * 3 + o)
            {
                case 0: lblFull.TextAlign = ContentAlignment.TopLeft; break;
                case 1: lblFull.TextAlign = ContentAlignment.TopCenter; break;
                case 2: lblFull.TextAlign = ContentAlignment.TopRight; break;
                case 3: lblFull.TextAlign = ContentAlignment.MiddleLeft; break;
                case 4: lblFull.TextAlign = ContentAlignment.MiddleCenter; break;
                case 5: lblFull.TextAlign = ContentAlignment.MiddleRight; break;
                case 6: lblFull.TextAlign = ContentAlignment.BottomLeft; break;
                case 7: lblFull.TextAlign = ContentAlignment.BottomCenter; break;
                case 8: lblFull.TextAlign = ContentAlignment.BottomRight; break;
            }
        }
    }
}
