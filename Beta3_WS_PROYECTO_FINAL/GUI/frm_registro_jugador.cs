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
    public partial class frm_registro_jugador : Form
    {
        public frm_registro_jugador()
        {
            InitializeComponent();
        }

        private void btn_cancelarjugador_registro_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void chk_condicion_Load(object sender, EventArgs e)
        {
            chk_condicion.Checked = false;
        }
    }
}
