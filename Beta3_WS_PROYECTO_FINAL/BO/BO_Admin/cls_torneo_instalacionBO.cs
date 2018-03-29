using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_torneo_instalacionBO
    {
        private int id_instalacion;
        private string nombre_instalacion;
        private int id_torneo;


        public int Id_instalacion { get => id_instalacion; set => id_instalacion = value; }
        public string Nombre_instalacion { get => nombre_instalacion; set => nombre_instalacion = value; }
        public int Id_torneo { get => id_torneo; set => id_torneo = value; }
    }
}
