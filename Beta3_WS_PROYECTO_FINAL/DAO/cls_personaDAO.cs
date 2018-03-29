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
            string ComandoSQL = string.Format("SELECT * FROM persona");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }

        public int AgregarDt(cls_personaBO obj_persona)
        {
            string ComandoSQL = string.Format("INSERT INTO  persona (matricula,Nombre,Apelido_Paterno,Apelido_Materno,Correo_Electronico,Telefono,Genero,tipo_persona,id_usuario,Idequipo,)VALUES ({0},'{1}','{2}',{3},'{4}','{5}',{6},{7},{8},{9});", obj_persona.Matricula_persona, obj_persona.Nombre_persona, obj_persona.ApePat_persona, obj_persona.ApeMar_persona, obj_persona.CorreoElect_persona, obj_persona.Telefono_persona, obj_persona.Genero_persona, obj_persona.Tipo_persona, obj_persona.Id_usuario, obj_persona.Id_equipo, obj_persona.Id_convocatoria);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarDt(cls_personaBO obj_persona)
        {
            string ComandoSQL = string.Format("UPDATE persona SET Nombre='{1}',Apelido_Paterno='{2}',Apelido_Materno='{3}',Correo_Electronico='{4}',Telefono='{5}',Genero={6},tipo_persona={7},id_usuario={8},Idequipo={9} WHERE matricula= {0}", obj_persona.Matricula_persona, obj_persona.Nombre_persona, obj_persona.ApePat_persona, obj_persona.ApeMar_persona, obj_persona.CorreoElect_persona, obj_persona.Telefono_persona, obj_persona.Genero_persona, obj_persona.Tipo_persona, obj_persona.Id_usuario, obj_persona.Id_convocatoria);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarDt(cls_personaBO obj_persona)
        {
            string ComandoSQL = string.Format("DELETE FROM persona WHERE matricula= {0}", obj_persona.Matricula_persona);
            return Miconexion.EjecutarComando(ComandoSQL);
        }


    }
}
