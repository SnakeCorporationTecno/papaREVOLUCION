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
using Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin;
using Beta3_WS_PROYECTO_FINAL.GUI;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_verArbitros_administrador : Form
    {
        cls_arbitroBO obj_arb = new cls_arbitroBO();
        cls_arbitroDAO obj_arbd = new cls_arbitroDAO();
        frm_AgregarAbitro arb = new frm_AgregarAbitro();
        public frm_verArbitros_administrador()
        {
            InitializeComponent();

            dgv_Arbitros.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Arbitros.ReadOnly = true;
            dgv_Arbitros.AllowUserToAddRows = false;
            dgv_Arbitros.DataSource = obj_arbd.BuscarArbitro();

            dgv_Arbitros.DataSource = obj_arbd.BuscarArbitro();
        }

        private void btn_cerrar_VerArbitros_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_reArb_vArb_Click(object sender, EventArgs e)
        {
            frm_AgregarAbitro objRegArbit = new frm_AgregarAbitro();
            objRegArbit.ShowDialog();
        }
        private void seleccionar_arbitro(object sender, DataGridViewCellMouseEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;


            obj_arb.Id_arbitro = int.Parse(dgv_Arbitros.Rows[filaSeleccionada].Cells["idarbitro"].Value.ToString());

            obj_arb.Nombre_arbitro = dgv_Arbitros.Rows[filaSeleccionada].Cells["Nombre"].Value.ToString();
            obj_arb.ApePat_arbitro = dgv_Arbitros.Rows[filaSeleccionada].Cells["Apelido_Paterno"].Value.ToString();
            obj_arb.ApeMat_arbitro= dgv_Arbitros.Rows[filaSeleccionada].Cells["Apelido_Materno"].Value.ToString();
            obj_arb.Genero_arbitro = Convert.ToBoolean(dgv_Arbitros.Rows[filaSeleccionada].Cells["Genero"].Value.ToString());

            txt_nombre_persona.Text = obj_arb.Nombre_arbitro;
            txt_apePat_persona.Text = obj_arb.ApePat_arbitro;
            txt_apeMat_persona.Text =obj_arb.ApeMat_arbitro;
           

            
        }
        private void btn_editArb_vArb_Click(object sender, EventArgs e)
        {
            if (obj_arbd.ModificarArbitro(RecuperarInformacion())==1)
            {
                MessageBox.Show("Registro modificado!!");
            }
            else
            {
                MessageBox.Show("Algo salio mal");
            }
            dgv_Arbitros.DataSource = obj_arbd.BuscarArbitro();
        }
        private cls_arbitroBO RecuperarInformacion()
        {
            obj_arb.Nombre_arbitro = txt_nombre_persona.Text;
            obj_arb.ApePat_arbitro = txt_apePat_persona.Text;
            obj_arb.ApeMat_arbitro = txt_apeMat_persona.Text;
            return obj_arb;
        }

        private void btn_eliminArb_vArb_Click(object sender, EventArgs e)
        {
           if (obj_arbd.EliminarArbitro(RecuperarInformacion()) == 1)
                {
                    MessageBox.Show("Registro Borrado");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");
                }
            dgv_Arbitros.DataSource = obj_arbd.BuscarArbitro();
        }

        private void btn_buscar_verArbit_administrador_Click(object sender, EventArgs e)
        {

            dgv_Arbitros.DataSource = obj_arbd.BuscarArbitro();

        }
    }
}
