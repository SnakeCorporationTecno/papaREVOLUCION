using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_equipo_partido
    {
        private int id_equipo;
        private int id_partido;

        public int Id_equipo
        {
            get
            {
                return id_equipo;
            }

            set
            {
                id_equipo = value;
            }
        }

        public int Id_partido
        {
            get
            {
                return id_partido;
            }

            set
            {
                id_partido = value;
            }
        }
    }
}
