using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_divisionBO
    {
        private int id_division;
        private string nombre_division;
        private string tipo_division;

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

        public string Nombre_division
        {
            get
            {
                return nombre_division;
            }

            set
            {
                nombre_division = value;
            }
        }

        public string Tipo_division
        {
            get
            {
                return tipo_division;
            }

            set
            {
                tipo_division = value;
            }
        }
    }
}
