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
    public class cls_carreraDAO
    {
        cls_conexion Miconexion;
        public cls_carreraDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable BuscarCarrera()
        {
            string ComandoSQL = string.Format("SELECT * FROM carrera");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarCarrera(cls_carreraBO obj_car)
        {
            string ComandoSQL = string.Format("INSERT INTO carrera(idcarrera,Nombre,Edificio,Iddivision) VALUES ({0},'{1}'{2}',{3});",obj_car.Id_carrera,obj_car.Nombre_carrera,obj_car.Nombre_edificio,obj_car.Id_division);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarCarrera(cls_carreraBO obj_car)
        {
            string ComandoSQL = string.Format("UPDATE carrera SET Nombre='{1}',Edificio='{2}',Iddivision={3} WHERE idcarrera={0}", obj_car.Id_carrera, obj_car.Nombre_carrera, obj_car.Nombre_edificio, obj_car.Id_division);
                return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int BorrarCarrera(cls_carreraBO obj_car)
        {
            string ComandoSQL = string.Format("DELETE FROM carrera WHERE idcarrera={0}",obj_car.Id_carrera);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
