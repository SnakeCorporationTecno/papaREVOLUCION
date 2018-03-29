using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beta3_WS_PROYECTO_FINAL.GUI.UC
{
    public partial class UC_cuenta_DT_ADMIN : UserControl
    {
        public UC_cuenta_DT_ADMIN()
        {
            InitializeComponent();
        }

        private void btn_añadorJuador1_Click(object sender, EventArgs e)
        {
            frm_registro_jugador objRegJug = new frm_registro_jugador();
            objRegJug.ShowDialog();
        }
    }
}
