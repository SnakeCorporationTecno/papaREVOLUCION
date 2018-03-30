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
    public class cls_torneoDAO
    {
        cls_conexion Miconexion;
        
        public cls_torneoDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarTorneo()
        {
            string ComandoSQL = string.Format("SELECT * FROM torneo");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarTorneo(cls_torneoBO obj_tor)
        {
            string ComandoSQL = string.Format("INSERT INTO torneo(idtorneo,Nombre,Fecha_inicio,Fecha_fin,Num_equipos,Ganador,Idconvocatoria) VALUES({0},'{1}','{2}','{3}',{4},'{5}',{6})",obj_tor.Id_torneo,obj_tor.Nombre_torneo,obj_tor.Fecha_inicio_torneo,obj_tor.Fecha_fin_torneo,obj_tor.Num_equipos_torneo,obj_tor.Ganador,obj_tor.Id_convocatoria);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarTorneo(cls_torneoBO obj_tor)
        {
            string ComandoSQL = string.Format("UPDATE torneo SET Nombre='{1}',Fecha_inicio='{2}',Fecha_fin='{3}',Num_equipo={4},Ganador='{5}',Idconvocatoria={6} WHERE idtorneo={0}",obj_tor.Id_torneo,obj_tor.Nombre_torneo,obj_tor.Fecha_inicio_torneo,obj_tor.Fecha_fin_torneo,obj_tor.Num_equipos_torneo,obj_tor.Ganador,obj_tor.Id_convocatoria);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int BorrarTorneo(cls_torneoBO obj_tor)
        {
            string ComandoSQL = string.Format("DELETE FROM torneo WHERE idtorneo={0}", obj_tor.Id_torneo);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
