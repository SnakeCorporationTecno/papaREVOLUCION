using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.DAO;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_personaDAO
    {
        cls_conexion Miconexion;

        public cls_personaDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable Buscar()
        {
            String ComandoSQL = string.Format("SELECT * FROM persona");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }

        /*public int AgregarDt(cls_personaBO obj_persona)
        {
            String ComandoSQL = string.Format("INSERT INTO  persona (matricula,Nombre,Apellido_Paterno,Apellido_Materno,Correo_Electronico,Telefono,Genero)VALUES ({0},'{1}','{2}',{3},'{4}','{5}',{6},{7});", obj_alumbo.Matricula, obj_alumbo.Nombre, obj_alumbo.Apellido, obj_alumbo.Id_div, obj_alumbo.Fechanac.ToString("yyyy-MM-dd HH:mm:ss"));
            return Miconexion.EjecutarComando(ComandoSQL);
        }*/

    }
}
