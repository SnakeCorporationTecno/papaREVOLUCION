using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beta3_WS_PROYECTO_FINAL.GUI;
using Beta3_WS_PROYECTO_FINAL.BO;


namespace Beta3_WS_PROYECTO_FINAL
{
    public partial class frm_principal : Form
    { //espero se pueda
        //variables panel 
        int moveTOG;
        int mValX;
        int mValY;

        public frm_principal()
        {
            InitializeComponent();
            /* if (datos.tipo == 'AD5')
             {
                 btn
             }*/
            lbl_nombreUS_main.Text = DatosLogin.nomuser;
           // lbl_nombreUS_main.BringToFront();
           if(DatosLogin.nomuser=="administrador")
            {
                btn_iniciar_sesion.Visible = false;

            }
        }

        private void btn_inicio_MouseHover(object sender, EventArgs e)
        {
            lbl_inicio.Text = "Inicio";
        }

        private void btn_inicio_MouseLeave(object sender, EventArgs e)
        {
            lbl_inicio.Text = "";
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lbl_inicio.Text = "";
            lbl_partidos.Text = "";
            lbl_equipos.Text = "";
            lbl_estadisticas.Text = "";
            lbl_convocatorias.Text = "";
            lbl_calendario.Text = "";
            
        }

        private void btn_partidos_MouseHover(object sender, EventArgs e)
        {
            lbl_partidos.Text = "Partidos";
        }

        private void btn_partidos_MouseLeave(object sender, EventArgs e)
        {
            lbl_partidos.Text = "";
        }

        private void btn_convocatorias_MouseHover(object sender, EventArgs e)
        {
            lbl_convocatorias.Text = "Convocatorias";
        }

        private void btn_convocatorias_MouseLeave(object sender, EventArgs e)
        {
            lbl_convocatorias.Text = "";
        }

        private void btn_equipos_MouseHover(object sender, EventArgs e)
        {
            lbl_equipos.Text = "Equipos";
        }

        private void btn_equipos_MouseLeave(object sender, EventArgs e)
        {
            lbl_equipos.Text = "";
        }

        private void btn_estadisticas_MouseHover(object sender, EventArgs e)
        {
            lbl_estadisticas.Text = "Estadísticas";
        }

        private void btn_estadisticas_MouseLeave(object sender, EventArgs e)
        {
            lbl_estadisticas.Text = "";
        }

        private void btn_calendario_MouseHover(object sender, EventArgs e)
        {
            lbl_calendario.Text = "Calendario";
        }

        private void btn_calendario_MouseLeave(object sender, EventArgs e)
        {
            lbl_calendario.Text = "";
        }

        private void btn_iniciarSesion_main_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_minimizar_main_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            uC_inicio1.BringToFront();
        }

        private void btn_partidos_Click(object sender, EventArgs e)
        {
            uC_partidos1.BringToFront();
        }

        private void btn_convocatorias_Click(object sender, EventArgs e)
        {
            uC_convocatorias1.BringToFront();
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            uC_equipos1.BringToFront();
        }

        private void btn_estadisticas_Click(object sender, EventArgs e)
        {
            uC_estadisticas1.BringToFront();
        }

        private void btn_calendario_Click(object sender, EventArgs e)
        {
            uC_calendario1.BringToFront();
        }

        private void btn_iniciar_sesion_Click(object sender, EventArgs e)
        {
            frm_login objLogin = new frm_login();
            objLogin.ShowDialog();
        }

        private void bim_logUS_main_Click(object sender, EventArgs e)
        {
            uC_cuenta_DT_ADMIN1.BringToFront();
        }

        private void lbl_nombreUS_main_Click(object sender, EventArgs e)
        {
            uC_cuenta_DT_ADMIN1.BringToFront();
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
