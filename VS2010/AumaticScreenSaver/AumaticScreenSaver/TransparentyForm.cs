using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AumaticScreenSaver
{
    public partial class TransparentyForm : Form//jest to prawie calkiem przezroczysty obiekt, na ktory dzialaja eventy
    {
        public TransparentyForm(Rectangle Bounds)
        {
            InitializeComponent();
            this.Bounds = Bounds;
            this.Opacity = 0.01;//ustawia przezroczystosc na 0.01

        }

        private void LineForm_Load(object sender, EventArgs e)
        {

        }

        private void LineForm_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();//gdy nastapi klikniecie mysza, aplikacja zostaje wylaczona
        }

        private void LineForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();//gdy nastapi wcisniecie klawisza, aplikacja zostaje wylaczona
        }
        private Point mouseLocation;
        private void LineForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseLocation.IsEmpty)
            {
                // zachodzi jesli mysz zmieni polozenie o dany dystans
                if (Math.Abs(mouseLocation.X - e.X) > 5 ||
                    Math.Abs(mouseLocation.Y - e.Y) > 5)
                    Application.Exit();//wylacza aplikacje
            }
            mouseLocation = e.Location;
        }
    }
}
