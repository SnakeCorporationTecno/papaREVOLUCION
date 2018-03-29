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
    public partial class UC_convocatorias : UserControl
    {
        public UC_convocatorias()
        {
            InitializeComponent();
        }

        private void btn_addconvocatoria_Click(object sender, EventArgs e)
        {
            frm_registro_convocatoria objRegConvo = new frm_registro_convocatoria();
            objRegConvo.ShowDialog();
        }
    }
}
