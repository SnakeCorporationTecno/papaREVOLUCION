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
        private int id_torneo;

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

        public int Id_torneo
        {
            get
            {
                return id_torneo;
            }

            set
            {
                id_torneo = value;
            }
        }
    }
}
