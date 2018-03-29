using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_convocatoriaBO
    {
        private int id_convocatoria;
        private string nombre_convocatoria;
        private DateTime fecha_inicio_convocatoria;
        private DateTime fecha_fin_convocatoria;
        private int numero_equipos;
        private bool tipo_categoria;
        private string tipo_convocatoria;
        private int Num_torneos;

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

        public string Nombre_convocatoria
        {
            get
            {
                return nombre_convocatoria;
            }

            set
            {
                nombre_convocatoria = value;
            }
        }

        public DateTime Fecha_inicio_convocatoria
        {
            get
            {
                return fecha_inicio_convocatoria;
            }

            set
            {
                fecha_inicio_convocatoria = value;
            }
        }

        public DateTime Fecha_fin_convocatoria
        {
            get
            {
                return fecha_fin_convocatoria;
            }

            set
            {
                fecha_fin_convocatoria = value;
            }
        }

        public int Numero_equipos
        {
            get
            {
                return numero_equipos;
            }

            set
            {
                numero_equipos = value;
            }
        }

        public bool Tipo_categoria
        {
            get
            {
                return tipo_categoria;
            }

            set
            {
                tipo_categoria = value;
            }
        }

        public string Tipo_convocatoria
        {
            get
            {
                return tipo_convocatoria;
            }

            set
            {
                tipo_convocatoria = value;
            }
        }

        public int Num_torneos1
        {
            get
            {
                return Num_torneos;
            }

            set
            {
                Num_torneos = value;
            }
        }
    }
}
