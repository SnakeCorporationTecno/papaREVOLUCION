using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_equipoBO
    {
        private int id_equipo;
        private string nombre_equipo;
        private int cant_jugadores;
        private int part_jugados;
        private string goleador;
        private int ranking;
        private int part_ganados;
        private int part_perdidos;
        private int id_convocatoria;
        private int puntaje;
        private string nombre_expulsado;

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

        public string Nombre_equipo
        {
            get
            {
                return nombre_equipo;
            }

            set
            {
                nombre_equipo = value;
            }
        }

        public int Cant_jugadores
        {
            get
            {
                return cant_jugadores;
            }

            set
            {
                cant_jugadores = value;
            }
        }

        public int Part_jugados
        {
            get
            {
                return part_jugados;
            }

            set
            {
                part_jugados = value;
            }
        }

        public string Goleador
        {
            get
            {
                return goleador;
            }

            set
            {
                goleador = value;
            }
        }

        public int Ranking
        {
            get
            {
                return ranking;
            }

            set
            {
                ranking = value;
            }
        }

        public int Part_ganados
        {
            get
            {
                return part_ganados;
            }

            set
            {
                part_ganados = value;
            }
        }

        public int Part_perdidos
        {
            get
            {
                return part_perdidos;
            }

            set
            {
                part_perdidos = value;
            }
        }

        public int Id_convocatoria
        {
            get
            {
                return id_convocatoria;
            }

            set
            {
                id_convocatoria = value;
            }
        }

        public int Puntaje
        {
            get
            {
                return puntaje;
            }

            set
            {
                puntaje = value;
            }
        }

        public string Nombre_expulsado
        {
            get
            {
                return nombre_expulsado;
            }

            set
            {
                nombre_expulsado = value;
            }
        }
    }
}
