using System.Linq;
using System.Text;
using System.Data;
using Beta3_WS_PROYECTO_FINAL.BO;
using MySql.Data.MySqlClient;
using Beta3_WS_PROYECTO_FINAL.DAO;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.DAO
{
    public class cls_convocatoriaDAO
    {
        cls_conexion Miconexion;
        public cls_convocatoriaDAO()
        {
            Miconexion = new cls_conexion();
        }
        public DataTable Buscar()
        {
            string ComandoSQL = string.Format("SELECT * FROM convocatoria");
            return Miconexion.EjercutarSentecia(ComandoSQL);
        }
        public int AgregarDivision(cls_convocatoriaBO obj_conv)
        {
            string ComandoSQL = string.Format("INSERT INTO convocatoria(idconvocatoria,Nombre,Fecha_incio,Fecha_fin,Num_equipos,tipo_Categoria,tipo_convocatoria,Num_torneos) VALUES ({0},'{1}','{2}','{3}',{4},{5},'{6}',{7});", obj_conv.Id_convocatoria, obj_conv.Nombre_convocatoria, obj_conv.Fecha_inicio_convocatoria.ToString("yyyy-MM-dd HH:mm:ss"),obj_conv.Fecha_fin_convocatoria.ToString("yyyy-MM-dd HH:mm:ss"),obj_conv.Numero_equipos,obj_conv.Tipo_categoria,obj_conv.Tipo_convocatoria,obj_conv.Num_torneos1);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int ModificarDivision(cls_convocatoriaBO obj_conv)
        {
            string ComandoSQL = string.Format("UPDATE convocatoria SET Nombre='{1}',Fecha_incio='{2}',Fecha_fin='{3}',Num_equipos={4},tipo_Categoria={5},tipo_convocatoria='{6}',Num_torneos={7} WHERE idconvocatoria={0}", obj_conv.Id_convocatoria, obj_conv.Nombre_convocatoria, obj_conv.Fecha_inicio_convocatoria.ToString("yyyy-MM-dd HH:mm:ss"), obj_conv.Fecha_fin_convocatoria.ToString("yyyy-MM-dd HH:mm:ss"), obj_conv.Numero_equipos, obj_conv.Tipo_categoria, obj_conv.Tipo_convocatoria, obj_conv.Num_torneos1);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
        public int EliminarDivision(cls_convocatoriaBO obj_conv)
        {
            string ComandoSQL = string.Format("DELETE FROM convocatoria WHERE idconvocatoria={0}", obj_conv.Id_convocatoria);
            return Miconexion.EjecutarComando(ComandoSQL);
        }
    }
}
