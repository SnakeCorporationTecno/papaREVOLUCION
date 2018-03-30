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
    public partial class frm_RegistrarDT : Form
    {
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

        private void btn_cancelarpersona_registroDT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
