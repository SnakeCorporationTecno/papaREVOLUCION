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
    public partial class frm_verEquipo : Form
    {
        public frm_verEquipo()
        {
            InitializeComponent();
        }

        private void btn_modInformacion_verEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_agregar_equipos_DT_Admin ojbAddequipo = new frm_agregar_equipos_DT_Admin();
            ojbAddequipo.ShowDialog();
        }

        private void btn_cancelar(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_verEquipo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
