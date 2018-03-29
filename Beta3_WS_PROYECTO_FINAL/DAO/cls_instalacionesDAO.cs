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
    public class cls_instalacionesDAO
    {
        cls_conexion Miconexion;
        public cls_instalacionesDAO()
        {
            Miconexion = new cls_conexion();

        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM instalaciones");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarInstalacion(cls_instalacionesBO obj_ins)
        {
            string ComandoSQL = string.Format("INSERT INTO  persona (idinstalacion,Nombre,Ubicacion,Tipo_cancha)VALUES ({0},'{1}','{2}','{3}');", obj_ins.Id_instalacion, obj_ins.Nombre_instalacion, obj_ins.Ubicacion_instalacion, obj_ins.Tip_cancha);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarInstalacion(cls_instalacionesBO obj_ins)
        {
            string ComandoSQL = string.Format("UPDATE persona SET Nombre='{1}',Ubicacion='{2}',Tipo_cancha='{3}' WHERE idinstalacion= {0}", obj_ins.Id_instalacion, obj_ins.Nombre_instalacion, obj_ins.Ubicacion_instalacion, obj_ins.Tip_cancha);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarInstalacion(cls_instalacionesBO obj_ins)
        {
            string ComandoSQL = string.Format("DELETE FROM instalaciones WHERE idinstalacion= {0}", obj_ins.Id_instalacion);
            return Miconexion.EjecutarComando(ComandoSQL);
        }



    }
}
