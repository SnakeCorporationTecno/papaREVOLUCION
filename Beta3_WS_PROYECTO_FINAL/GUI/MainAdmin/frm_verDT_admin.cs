using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_verDT_admin : Form
    {
        public frm_verDT_admin()
        {
            InitializeComponent();
        }

        private void btn_cerrar_vDT_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_reDT_vDT_Click(object sender, EventArgs e)
        {
            frm_RegistrarDT objRegDT = new frm_RegistrarDT();
            objRegDT.ShowDialog();
        }

        private void btn_changeUsPass_VerDT_Click(object sender, EventArgs e)
        {
            //este abre el Registrar usuario y contraseña 2
            frm_RegistrarDT_US2 objRegDTUS2 = new frm_RegistrarDT_US2();
            objRegDTUS2.ShowDialog();
        }
    }
}
