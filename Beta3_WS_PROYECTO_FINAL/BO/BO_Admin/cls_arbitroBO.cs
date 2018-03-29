using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    public class cls_arbitroBO
    {
        private int id_arbitro;
        private string nombre_arbitro;
        private string apePat_arbitro;
        private string apeMat_arbitro;
        private bool genero_arbitro;

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

        public string Nombre_arbitro
        {
            get
            {
                return nombre_arbitro;
            }

            set
            {
                nombre_arbitro = value;
            }
        }

        public string ApePat_arbitro
        {
            get
            {
                return apePat_arbitro;
            }

            set
            {
                apePat_arbitro = value;
            }
        }

        public string ApeMat_arbitro
        {
            get
            {
                return apeMat_arbitro;
            }

            set
            {
                apeMat_arbitro = value;
            }
        }

        public bool Genero_arbitro
        {
            get
            {
                return genero_arbitro;
            }

            set
            {
                genero_arbitro = value;
            }
        }
    }
}
