using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_jugadoresBO
    {
        private int matricula_jugadorM;
        private string nombre_jugador;
        private string apePat_jugador;
        private string apeMat_jugador;
        private string pocision_jugador;
        private int dorsal_jugador;
        private double genero_jugador;
        private bool condicion_jugador;
        private int partidos_jugados_jugador;
        private int id_equipo;
        private int id_division;

        public int Matricula_jugadorM
        {
            get
            {
                return matricula_jugadorM;
            }

            set
            {
                matricula_jugadorM = value;
            }
        }

        public string Nombre_jugador
        {
            get
            {
                return nombre_jugador;
            }

            set
            {
                nombre_jugador = value;
            }
        }

        public string ApePat_jugador
        {
            get
            {
                return apePat_jugador;
            }

            set
            {
                apePat_jugador = value;
            }
        }

        public string ApeMat_jugador
        {
            get
            {
                return apeMat_jugador;
            }

            set
            {
                apeMat_jugador = value;
            }
        }

        public string Pocision_jugador
        {
            get
            {
                return pocision_jugador;
            }

            set
            {
                pocision_jugador = value;
            }
        }

        public int Dorsal_jugador
        {
            get
            {
                return dorsal_jugador;
            }

            set
            {
                dorsal_jugador = value;
            }
        }

        public double Genero_jugador
        {
            get
            {
                return genero_jugador;
            }

            set
            {
                genero_jugador = value;
            }
        }

        public bool Condicion_jugador
        {
            get
            {
                return condicion_jugador;
            }

            set
            {
                condicion_jugador = value;
            }
        }

        public int Partidos_jugados_jugador
        {
            get
            {
                return partidos_jugados_jugador;
            }

            set
            {
                partidos_jugados_jugador = value;
            }
        }

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

        public int Id_division
        {
            get
            {
                return id_division;
            }

            set
            {
                id_division = value;
            }
        }
    }
}
