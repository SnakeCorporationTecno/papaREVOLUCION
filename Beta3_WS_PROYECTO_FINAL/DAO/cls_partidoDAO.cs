using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.BO;
using Beta3_WS_PROYECTO_FINAL.DAO;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    class cls_partidoDAO
    {
        cls_conexion Miconexion;

        public cls_partidoDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarPartido()
        {
            string ComandoSQL = string.Format("SELECT * FROM partido");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }

        public int AgregarPartido(cls_partidoBO obj_part)
        {
            string ComandoSQL = string.Format("INSERT INTO partido(idpartido,Duracion,Hora_Inicio,Hora_Fin,Dia_Partido,Resultado,Idarbitro) VALUES ({0},'{1}','{2}','{3}','{4}','{5}','{6}',{7});", obj_part.Id_partido, obj_part.Duracion, obj_part.Hora_inicio, obj_part.Hora_fin, obj_part.Dia_partido,obj_part.Resultado_partido,obj_part.Id_arbitro);
            return Miconexion.EjecutarComando(ComandoSQL);
        }

        public int ModificarPartido(cls_partidoBO obj_part)
        {
            string 
        }
    }
}
