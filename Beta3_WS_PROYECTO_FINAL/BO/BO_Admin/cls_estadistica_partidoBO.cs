using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_estadistica_partidoBO
    {
        private int estadistica;
        private int partido;

        public int Estadistica
        {
            get
            {
                return estadistica;
            }

            set
            {
                estadistica = value;
            }
        }

        public int Partido
        {
            get
            {
                return partido;
            }

            set
            {
                partido = value;
            }
        }
    }
}
