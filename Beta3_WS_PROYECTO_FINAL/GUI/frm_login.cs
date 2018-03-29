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
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.GUI;
using System.Data;


namespace Beta3_WS_PROYECTO_FINAL.GUI
{
    public partial class frm_login : Form
    {
        ClsUsuariO_DAO  obj = new ClsUsuariO_DAO();
        cls_usuarioBO obUsuario = new cls_usuarioBO();
        public frm_login()
        {
            InitializeComponent();
           
        }

        private void btn_cancelar_login_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciarSesion_login_Click(object sender, EventArgs e)
        {

       
            DataTable datos = obj.DevuelveLogin(RecuperarInformacion());
            if (datos.Rows.Count >= 1)
            {
                MessageBox.Show("Bienvenido");
                //DatosLogin.nomuser = obUsuario.Username;
                //DatosLogin.passuser = obUsuario.Password;
                //frm_principal obj = new frm_principal();
                //obj.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usurio y/o contraseña invalidos");
            }





        }
        private cls_usuarioBO RecuperarInformacion()
        {
            // Se recupera toda la información del formulario


            obUsuario.Username= txt_username.Text;
            obUsuario.Password = txt_password.Text;

            return obUsuario;
        }
    }
}
