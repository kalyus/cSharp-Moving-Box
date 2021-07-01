using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                    if((box.Left + 10) < (this.Width - box.Width))
                    {
                        box.Left += 10;
                    }
                    
                    break;

                case Keys.A:
                    if ((box.Left - 10) > 0)
                    {
                        box.Left -= 10;
                    }

                    break;

                case Keys.W:
                    if ((box.Top - 10) > 0)
                    {
                        box.Top -= 10;
                    }

                    break;

                case Keys.S:
                    if ((box.Top) < (this.Height - box.Height))
                    {
                        box.Top += 10;
                    }

                    break;
            }

        }
    }
}
