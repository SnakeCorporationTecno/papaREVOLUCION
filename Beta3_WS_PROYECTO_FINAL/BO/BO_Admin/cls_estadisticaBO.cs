using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_estadisticaBO
    {
        private int id_estadistica;
        private int tot_goles;
        private int tot_faltas;
        private int tot_penales;
        private int expulsados;

        public int Id_estadistica
        {
            get
            {
                return id_estadistica;
            }

            set
            {
                id_estadistica = value;
            }
        }

        public int Tot_goles
        {
            get
            {
                return tot_goles;
            }

            set
            {
                tot_goles = value;
            }
        }

        public int Tot_faltas
        {
            get
            {
                return tot_faltas;
            }

            set
            {
                tot_faltas = value;
            }
        }

        public int Tot_penales
        {
            get
            {
                return tot_penales;
            }

            set
            {
                tot_penales = value;
            }
        }

        public int Expulsados
        {
            get
            {
                return expulsados;
            }

            set
            {
                expulsados = value;
            }
        }
    }
}
