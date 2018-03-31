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
    public class cls_jugadoresDAO
    {
        cls_conexion Miconexion;

        public cls_jugadoresDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarArbitro()
        {
            string ComandoSQL = string.Format("SELECT * FROM jugadores");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarJugador(cls_jugadoresBO obj_jug)
        {
            string ComandoSQL = string.Format("INSERT INTO jugadores(matricula,Nombre,Apelido_Paterno,Apelido_Materno,Posicion,Dorsal,Genero,Condicion,Partidos_Jugados,Idequipo,Iddivision) VALUES ({0},'{1}','{2}','{3}','{4}',{5},{6},{7},{8},{9},{10});", obj_jug.Matricula_jugadorM, obj_jug.Nombre_jugador, obj_jug.ApePat_jugador, obj_jug.ApeMat_jugador, obj_jug.Pocision_jugador,obj_jug.Dorsal_jugador,obj_jug.Genero_jugador,obj_jug.Condicion_jugador,obj_jug.Id_equipo,obj_jug.Id_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarJugador(cls_jugadoresBO obj_jug)
        {
            string ComandoSQL = string.Format("UPDATE jugadores SET Nombre='{1}', Apelido_Paterno='{2}',Apelido_Materno='{3}',Posicion='{4}',Dorsal={5},Genero={6},Condicion{7},Partidos_Jugados={8},Idequipo={9},Iddivision{10} WHERE matricula={0}", obj_jug.Matricula_jugadorM, obj_jug.Nombre_jugador, obj_jug.ApePat_jugador, obj_jug.ApeMat_jugador, obj_jug.Pocision_jugador, obj_jug.Dorsal_jugador, obj_jug.Genero_jugador, obj_jug.Condicion_jugador, obj_jug.Id_equipo, obj_jug.Id_division);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarJugador(cls_jugadoresBO obj_jug)
        {
            string ComandoSQL = string.Format("DELETE FROM jugadores WHERE matricula={0}", obj_jug.Matricula_jugadorM);
            return Miconexion.EjecutarComando(ComandoSQL);
        }//
    }
}
