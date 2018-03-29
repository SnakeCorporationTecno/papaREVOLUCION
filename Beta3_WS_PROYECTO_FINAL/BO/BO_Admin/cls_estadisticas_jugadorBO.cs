using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_estadisticas_jugadorBO
    {
        private int id_estadisticas;
        private int id_jugador;

        public int Id_estadisticas
        {
            get
            {
                return id_estadisticas;
            }

            set
            {
                id_estadisticas = value;
            }
        }

        public int Id_jugador
        {
            get
            {
                return id_jugador;
            }

            set
            {
                id_jugador = value;
            }
        }
    }
}
