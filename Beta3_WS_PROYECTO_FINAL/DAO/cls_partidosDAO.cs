using System.Linq;
using System.Text;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.DAO;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_partidosDAO
    {
        cls_conexion Miconexion;

        public cls_partidosDAO()
        {
            Miconexion = new cls_conexion();
        } 
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM partido");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }

       public int AgregarPartidos(cls_partidoBO obj_par)
        {
            string ComandoSQL = string.Format("INSERT INTO partido(idpartido,Duracion,Hora_Inicio,Hora_Fin,Dia_Partido,Resultado,Idarbitro) VALUES ({0},'{1}','{2}','{3}','{4}','{5}',{6})",obj_par.Id_partido,obj_par.Duracion,obj_par.Hora_inicio,obj_par.Hora_fin,obj_par.Dia_partido,obj_par.Resultado_partido,obj_par.Id_arbitro);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarPartido(cls_partidoBO obj_par)
        {
            string ComandoSQL = string.Format("UPDATE partido SET Duracion='{1}',Hora_Inicio='{2}',Hora_Fin='{3}',Dia_Partido='{4}',Resultado='{5}',Idarbitro={6} WHERE idpartido= {0}", obj_par.Id_partido, obj_par.Duracion, obj_par.Hora_inicio, obj_par.Hora_fin, obj_par.Dia_partido, obj_par.Resultado_partido, obj_par.Id_arbitro);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int BorrarPartido(cls_partidoBO obj_par)
        {
            string ComandoSQL = string.Format("DELETE FROM partidos WHERE idpartido={0}", obj_par.Id_partido);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
