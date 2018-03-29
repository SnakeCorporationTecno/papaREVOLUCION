using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_carreraBO
    {
        private int id_carrera;
        private string nombre_carrera;
        private string nombre_edificio;
        private int id_division;

        public int Id_carrera
        {
            get
            {
                return id_carrera;
            }

            set
            {
                id_carrera = value;
            }
        }

        public string Nombre_carrera
        {
            get
            {
                return nombre_carrera;
            }

            set
            {
                nombre_carrera = value;
            }
        }

        public string Nombre_edificio
        {
            get
            {
                return nombre_edificio;
            }

            set
            {
                nombre_edificio = value;
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
