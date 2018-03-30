using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beta3_WS_PROYECTO_FINAL.BO;
using Beta3_WS_PROYECTO_FINAL.DAO;

namespace Beta3_WS_PROYECTO_FINAL.GUI
{
    public partial class frm_registro_convocatoria : Form
    {
        cls_convocatoriaBO obj_con = new cls_convocatoriaBO();
        cls_convocatoriaDAO obj_cond = new cls_convocatoriaDAO();
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
            bool validacion = validacioncampos();
            if (validacion == true)
            {
                EP_convo.Clear();
                MessageBox.Show("Nombre arbitro" + txt_Nom_conv.Text + "\nFecha inicio" + dtp_fechainicio + "  " + "Fecha fin" + dtp_fechafin + "\nTipo convocatoria" + cb_tipoconvocatoria );

                if (obj_cond.AgregarConvocatoria(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Registro Agregado");
                }
                else
                {
                    MessageBox.Show("Algo salio Mal");
                }
            }
            frm_registroTorneo objtorn = new frm_registroTorneo();
            this.Hide();
            objtorn.ShowDialog();
        }

        private void btn_cancelarpersona_registroconv_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private cls_convocatoriaBO RecuperarInformacion()
        {
            // Se recupera toda la información del formulario
            // Aquí se validan todos los datos.


            obj_con.Nombre_convocatoria = txt_Nom_conv.Text;

            obj_con.Fecha_inicio_convocatoria = Convert.ToDateTime(dtp_fechainicio.Text);
            obj_con.Fecha_fin_convocatoria = Convert.ToDateTime(dtp_fechafin.Text);
            obj_con.Tipo_categoria = Convert.ToBoolean(rb_Varonil.ToString());
            obj_con.Tipo_categoria = Convert.ToBoolean(rb_Femenil.ToString());
            obj_con.Tipo_convocatoria = cb_tipoconvocatoria.ToString();
            return obj_con;
        }
        public bool validacioncampos()
        {
            bool validado = true;
            if (String.IsNullOrWhiteSpace(txt_Nom_conv.Text))
            {
                EP_convo.SetError(txt_Nom_conv, "No puede ir vacio");
                validado = false;
            }
            else
            {
                EP_convo.SetError(txt_Nom_conv, "");
            }
            if (String.IsNullOrWhiteSpace(dtp_fechainicio.Text))
            {
                EP_convo.SetError(dtp_fechainicio, "No puede ir vacio");
                validado = false;
            }
            else
            {
                EP_convo.SetError(dtp_fechainicio, "");
            }
            if (String.IsNullOrWhiteSpace(dtp_fechafin.Text))
            {
                EP_convo.SetError(dtp_fechafin, "No puede ir vacio");
                validado = false;
            }
            else
            {
                EP_convo.SetError(dtp_fechafin, "");
            }
            if(String.IsNullOrWhiteSpace(cb_tipoconvocatoria.Text))
            {
                EP_convo.SetError(cb_tipoconvocatoria, "No puede ir vacio");
                validado = false;
            }
            else
            {
                EP_convo.SetError(cb_tipoconvocatoria, "");
            }

            return validado;
        }
    }
}
