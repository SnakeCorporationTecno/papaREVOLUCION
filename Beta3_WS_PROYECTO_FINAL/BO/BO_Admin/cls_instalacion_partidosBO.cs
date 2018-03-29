using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_instalacion_partidosBO
    {
        private int id_instalacion;
        private int id_partidos;

        public int Id_instalacion
        {
            get
            {
                return id_instalacion;
            }

            set
            {
                id_instalacion = value;
            }
        }

        public int Id_partidos
        {
            get
            {
                return id_partidos;
            }

            set
            {
                id_partidos = value;
            }
        }
    }
}
