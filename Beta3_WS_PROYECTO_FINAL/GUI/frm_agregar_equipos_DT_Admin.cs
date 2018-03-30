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
    public partial class frm_agregar_equipos_DT_Admin : Form
    {
        public frm_agregar_equipos_DT_Admin()
        {
            InitializeComponent();
        }

        private void btn_add_jug_equipo_Click(object sender, EventArgs e)
        {
            frm_registro_jugador objRegJug = new frm_registro_jugador();
            objRegJug.ShowDialog();
        }
    }
}
