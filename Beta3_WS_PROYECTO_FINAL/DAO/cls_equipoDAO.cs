using System.Linq;
using System.Text;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.DAO;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_equipoDAO
    {
        cls_conexion Miconexion;
        public cls_equipoDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM equipo");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarEquipo(cls_equipoBO obj_equi)
        {
            string ComandoSQL = string.Format("INSERT INTO equipo(idequipo,Nombre,Cantidad_Jugadores,partidos_jugados,Goleador,ranking,partidos_ganados,partidos_perdidos,Idconvocatoria,Puntaje,Nombre_expulsado) VALUES ({0},'{1}',{2},{3},'{4}',{5},{6},{7},{8},{9},'{10}');", obj_equi.Id_equipo, obj_equi.Nombre_equipo, obj_equi.Cant_jugadores, obj_equi.Part_jugados, obj_equi.Goleador, obj_equi.Ranking, obj_equi.Part_ganados, obj_equi.Part_perdidos,obj_equi.Id_convocatoria,obj_equi.Puntaje,obj_equi.Nombre_expulsado);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarEquipo(cls_equipoBO obj_equi)
        {
            string ComandoSQL = string.Format("UPDATE equipo SET Nombre='{1}',Cantidad_Jugadores={2},partidos_jugados={3},Goleador='{4}',ranking={5},partidos_ganados={6},partidos_perdidos={7},Idconvocatoria={8},Puntaje={9},Nombre_expulsadi='{10}' WHERE idequipo={0}", obj_equi.Id_equipo, obj_equi.Nombre_equipo, obj_equi.Cant_jugadores, obj_equi.Part_jugados, obj_equi.Goleador, obj_equi.Ranking, obj_equi.Part_ganados, obj_equi.Part_perdidos,obj_equi.Id_convocatoria,obj_equi.Puntaje,obj_equi.Nombre_expulsado);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarEquipo(cls_equipoBO obj_equi)
        {
            string ComandoSQL = string.Format("DELETE FROM convocatoria WHERE idequipo={0}", obj_equi.Id_equipo);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
