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
    public class cls_estadisticasDAO
    {
        cls_conexion Miconexion;

        public cls_estadisticasDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarEstadisticas()
        {
            string ComandoSQL = string.Format("SELECT * FROM estadisticas");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarEstadisticas(cls_estadisticaBO obj_est)
        {
            string ComandoSQL = string.Format("INSERT INTO estadisticas(idestadisticas,Total_Goles,Total_Faltas,Total_Penales,Expulsados) VALUES({0},{1},{2},{3},{4})",obj_est.Id_estadistica,obj_est.Tot_goles,obj_est.Tot_faltas,obj_est.Tot_penales,obj_est.Expulsados);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarEstadisticas(cls_estadisticaBO obj_est)
        {
            string ComandoSQL = string.Format("UPDATE torneo SET Total_Goles={1},Total_Faltas={2},Total_Penales={3},Expulsados={4} WHERE idestadisticas={0}", obj_est.Id_estadistica, obj_est.Tot_goles, obj_est.Tot_faltas, obj_est.Tot_penales, obj_est.Expulsados);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int BorrarEstadisticas(cls_estadisticaBO obj_est)
        {
            string ComandoSQL = string.Format("DELETE FROM estadisticas WHERE idestadisticas={0}", obj_est.Id_estadistica);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
