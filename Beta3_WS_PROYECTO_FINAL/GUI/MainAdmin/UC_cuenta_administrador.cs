using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Beta3_WS_PROYECTO_FINAL.GUI.MainAdmin;

namespace Beta3_WS_PROYECTO_FINAL.GUI.UC
{
    public partial class UC_cuenta_administrador : UserControl
    {
        public UC_cuenta_administrador()
        {
            InitializeComponent();
        }

        private void btn_addDT_Admin_Click(object sender, EventArgs e)
        {
            frm_verDT_admin objVerDT = new frm_verDT_admin();
            objVerDT.ShowDialog();
        }

        private void btn_addAdmin_Admin_Click(object sender, EventArgs e)
        {
            frm_verAdmin_admin objverAdmin = new frm_verAdmin_admin();
            objverAdmin.ShowDialog();
        }

        private void btn_addORG_Admin_Click(object sender, EventArgs e)
        {
            frm_verOrg_admin objVerOrg = new frm_verOrg_admin();
            objVerOrg.ShowDialog();
        }
    }
}
