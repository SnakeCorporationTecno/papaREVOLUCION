using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin
{
    public partial class frm_verEquipos_admin : Form
    {
        public frm_verEquipos_admin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            frm_agregar_equipos_DT_Admin objAddEquipo = new frm_agregar_equipos_DT_Admin();
            objAddEquipo.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frm_verEquipo objverEquipo = new frm_verEquipo();
            objverEquipo.ShowDialog();
        }
    }
}
