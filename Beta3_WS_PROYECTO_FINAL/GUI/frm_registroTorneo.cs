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
    public partial class frm_registroTorneo : Form
    {
        public frm_registroTorneo()
        {
            InitializeComponent();
        }

        private void btn_cancelarpersona_registroTorn_Click(object sender, EventArgs e)
        {
            frm_registro_convocatoria objconv = new frm_registro_convocatoria();
            this.Hide();
            objconv.ShowDialog();
        }
    }
}
