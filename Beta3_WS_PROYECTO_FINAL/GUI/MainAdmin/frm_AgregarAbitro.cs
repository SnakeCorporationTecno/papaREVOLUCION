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

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_AgregarAbitro : Form
    {
        cls_arbitroBO obj_arb = new cls_arbitroBO();
        cls_arbitroDAO obj_arbd = new cls_arbitroDAO();
        public frm_AgregarAbitro()
        {
            InitializeComponent();
        }

        private void btn_registrarpersona_registroArb_Click(object sender, EventArgs e)
        {
            bool validacion = validacioncampos();
            if (validacion== true)
            {
                errorProvider1.Clear();
                MessageBox.Show("Nombre arbitro" + txt_nombreArbitro.Text + "\nApellido arbitro" + txt_apePat_Arbitro + txt_apeMat_Arbitro);
            }
            if (obj_arbd.AgregarArbitro(RecuperarInformacion())==1)
            {
                MessageBox.Show("Registro Agregado");
            }
            else
            {
                MessageBox.Show("Algo salio Mal");
            }
            
            this.Hide();
            
        }
        private cls_arbitroBO RecuperarInformacion()
        {
            obj_arb.Nombre_arbitro = txt_nombreArbitro.Text;
            obj_arb.ApePat_arbitro = txt_apePat_Arbitro.Text;
            obj_arb.ApeMat_arbitro = txt_apeMat_Arbitro.Text;
            obj_arb.Genero_arbitro = Convert.ToBoolean(rbn_hombre_arbitro.ToString());
            obj_arb.Genero_arbitro = Convert.ToBoolean(rbn_mujer_Arbitro.ToString());
            return obj_arb;
        }
        public bool validacioncampos()
        {
            bool validado = true;
            if(String.IsNullOrWhiteSpace(txt_nombreArbitro.Text))
            {
                errorProvider1.SetError(txt_nombreArbitro, "No puede ir vacio");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(txt_nombreArbitro, "");
            }
            if(String.IsNullOrWhiteSpace(txt_apePat_Arbitro.Text))
            {
                errorProvider1.SetError(txt_apePat_Arbitro, "No puede ir vacio");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(txt_apePat_Arbitro, "");
            }
            if(String.IsNullOrWhiteSpace(txt_apeMat_Arbitro.Text))
            {
                errorProvider1.SetError(txt_apeMat_Arbitro, "No puede ir vacio");
                validado = false;
            }
            else
            {
                errorProvider1.SetError(txt_apeMat_Arbitro, "");
            }
            return validado;
        }

    }
}
