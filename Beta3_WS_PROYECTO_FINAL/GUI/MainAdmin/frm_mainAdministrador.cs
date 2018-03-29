using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_mainAdministrador : Form
    {
        //variables panel 
        int moveTOG;
        int mValX;
        int mValY;

        public frm_mainAdministrador()
        {
            InitializeComponent();
        }

        private void Panel_top_main_MouseDown(object sender, MouseEventArgs e)
        {
            moveTOG = 1;
            mValX = e.X;
            mValY = e.Y;

        }

        private void Panel_top_main_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveTOG == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }

        }

        private void Panel_top_main_MouseUp(object sender, MouseEventArgs e)
        {
            moveTOG = 0;

        }
    }
}
