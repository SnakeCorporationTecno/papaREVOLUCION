using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    class ClsUsuariO_DAO
    {

        cls_conexion con = new cls_conexion();
        DataSet dsLogin = null;
        string sql;
        MySqlCommand cmd;
        MySqlDataAdapter da;



        public DataTable DevuelveLogin(cls_usuarioBO obj)
        {
            string sql = string.Format("SELECT * FROM usuario WHERE username='{0}' and contrasena='{1}'", obj.Username, obj.Password);
            return con.EjercutarSentecia(sql);
        }

        public int AgregarNuevoUsuario(cls_divisionBO obj_div)
        {
            string ComandoSQL = string.Format("INSERT INTO division(iddivision,Nombre,Tipo_division) VALUES ({0},'{1}','{2}');", obj_div.Id_division, obj_div.Nombre_division, obj_div.Tipo_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }










    }
}
