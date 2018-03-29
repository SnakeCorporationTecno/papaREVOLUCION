using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.DAO;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_divisionDAO
    {
        cls_conexion Miconexion;
        public cls_divisionDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM division");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarDivision (cls_divisionBO obj_div)
        {
            string ComandoSQL = string.Format("INSERT INTO division(iddivision,Nombre,Tipo_division) VALUES ({0},'{1}','{2}');",obj_div.Id_division,obj_div.Nombre_division,obj_div.Tipo_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarDivision(cls_divisionBO obj_div)
        {
            string ComandoSQL = string.Format("UPDATE division SET Nombre='{1}', Tipo_division='{2}' WHERE iddivision= {0}",obj_div.Id_division,obj_div.Nombre_division,obj_div.Tipo_division);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarDivision(cls_divisionBO obj_div)
        {
            string ComandoSQL = string.Format("DELETE FROM division WHERE iddivision={0}", obj_div.Id_division);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
