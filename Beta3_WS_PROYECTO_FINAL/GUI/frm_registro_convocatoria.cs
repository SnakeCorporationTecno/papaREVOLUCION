using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI
{
    public partial class frm_registro_convocatoria : Form
    {
        int moveTOG;
        int mValX;
        int mValY;

        public frm_registro_convocatoria()
        {
            InitializeComponent();
        }

        private void btn_cerrar_convocatoria_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moveTOG = 1;
            mValX = e.X;
            mValY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveTOG == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValX, MousePosition.Y - mValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            {
                moveTOG = 0;
            }
        }

        private void btn_registrarpersona_registroconv_Click(object sender, EventArgs e)
        {
            frm_registroTorneo objtorn = new frm_registroTorneo();
            this.Hide();
            objtorn.ShowDialog();
        }

        private void btn_cancelarpersona_registroconv_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
