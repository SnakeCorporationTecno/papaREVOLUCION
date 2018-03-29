using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_partidoBO
    {
        private int id_partido;
        private DateTime duracion;
        private DateTime hora_inicio;
        private DateTime hora_fin;
        private DateTime dia_partido;
        private string resultado_partido;
        private int id_arbitro;

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

        public DateTime Duracion
        {
            get
            {
                return duracion;
            }

            set
            {
                duracion = value;
            }
        }

        public DateTime Hora_inicio
        {
            get
            {
                return hora_inicio;
            }

            set
            {
                hora_inicio = value;
            }
        }

        public DateTime Hora_fin
        {
            get
            {
                return hora_fin;
            }

            set
            {
                hora_fin = value;
            }
        }

        public DateTime Dia_partido
        {
            get
            {
                return dia_partido;
            }

            set
            {
                dia_partido = value;
            }
        }

        public string Resultado_partido
        {
            get
            {
                return resultado_partido;
            }

            set
            {
                resultado_partido = value;
            }
        }

        public int Id_arbitro
        {
            get
            {
                return id_arbitro;
            }

            set
            {
                id_arbitro = value;
            }
        }
    }
}
