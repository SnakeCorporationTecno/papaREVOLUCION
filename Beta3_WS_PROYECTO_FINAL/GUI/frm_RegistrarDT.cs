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
    public partial class frm_RegistrarDT : Form
    {
        cls_dt_bo obdt = new cls_dt_bo();
        public frm_RegistrarDT()
        {
            InitializeComponent();
        }

        private void btn_siguientepersona_registro_DT_Click(object sender, EventArgs e)
        {
            //Aqui se debe de agregar el codigo para enviar los datos de el form de los datos del dt am la base de datos

            frm_RegistrarDT_US objRegDTUS = new frm_RegistrarDT_US();
            this.Hide();
            objRegDTUS.ShowDialog();
        }











        private cls_dt_bo RecuperarInformacionArbitro()
        {
            // Se recupera toda la información del formulario
            // Aquí se validan todos los datos.
            int matricula = 0; int.TryParse(txt_matricula_dt.Text,  out matricula );

            obdt.Matricula_persona = matricula;
            obdt.Nombre_persona = txt_nombre_dt.Text;
            obdt.ApePat_persona = txt_apePat_dt.Text;
            obdt.ApeMar_persona= txt_apeMat_dt.Text;
            obdt.CorreoElect_persona = txt_correo_dt.Text;
            obdt.Telefono_persona = txt_numero_dt.Text;
            
            return obdt;
        }
        private void btn_cancelarpersona_registroDT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
