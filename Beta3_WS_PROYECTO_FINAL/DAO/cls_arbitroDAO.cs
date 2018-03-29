using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using System.Data;


namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_arbitroDAO
    {


        cls_conexion Miconexion;
       
        public cls_arbitroDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarArbitro()
        {
            string ComandoSQL = string.Format("SELECT * FROM arbitro");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarArbitro(cls_arbitroBO obj_arbitro)
        {
            string ComandoSQL = string.Format("INSERT INTO arbitro(idarbitro,Nombre,Apelido_Paterno,Apelido_Materno,Genero) VALUES ({0},'{1}','{2}','{3}',{4});", obj_arbitro.Id_arbitro,obj_arbitro.Nombre_arbitro,obj_arbitro.ApePat_arbitro,obj_arbitro.ApeMat_arbitro,obj_arbitro.Genero_arbitro);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarDivision(cls_divisionBO obj_division)
        {
            string ComandoSQL = string.Format("UPDATE division SET Nombre='{1}', Tipo_division='{2}'", obj_div.Id_division, obj_div.Nombre_division, obj_div.Tipo_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarDivision(cls_divisionBO obj_division)
        {
            string ComandoSQL = string.Format("DELETE FROM division WHERE iddivision={0}", obj_div.Id_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
    }

                
}
