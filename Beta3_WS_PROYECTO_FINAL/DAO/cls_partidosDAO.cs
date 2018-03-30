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

        public int 
    }
}
