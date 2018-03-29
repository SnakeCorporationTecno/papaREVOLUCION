using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_instalacionesBO
    {
        private int id_instalacion;
        private string nombre_instalacion;
        private string ubicacion_instalacion;
        private string tip_cancha;


        public int Id_instalacion { get => id_instalacion; set => id_instalacion = value; }
        public string Nombre_instalacion { get => nombre_instalacion; set => nombre_instalacion = value; }
        public string Ubicacion_instalacion { get => ubicacion_instalacion; set => ubicacion_instalacion = value; }
        public string Tip_cancha { get => tip_cancha; set => tip_cancha = value; }
    }
}
