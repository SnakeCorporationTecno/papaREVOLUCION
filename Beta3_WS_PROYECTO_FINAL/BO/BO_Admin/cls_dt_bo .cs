using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    public class cls_dt_bo
    {
        private int matricula_persona;
        private string nombre_persona;
        private string apePat_persona;
        private string apeMar_persona;
        private string correoElect_persona;
        private string telefono_persona;
        
        private int tipo_persona;
        private int id_usuario;
        private int id_equipo;
       

        public int Matricula_persona
        {
            get
            {
                return matricula_persona;
            }

            set
            {
                matricula_persona = value;
            }
        }

        public string Nombre_persona
        {
            get
            {
                return nombre_persona;
            }

            set
            {
                nombre_persona = value;
            }
        }

        public string ApePat_persona
        {
            get
            {
                return apePat_persona;
            }

            set
            {
                apePat_persona = value;
            }
        }

        public string ApeMar_persona
        {
            get
            {
                return apeMar_persona;
            }

            set
            {
                apeMar_persona = value;
            }
        }

        public string CorreoElect_persona
        {
            get
            {
                return correoElect_persona;
            }

            set
            {
                correoElect_persona = value;
            }
        }

        public string Telefono_persona
        {
            get
            {
                return telefono_persona;
            }

            set
            {
                telefono_persona = value;
            }
        }

       

        public int Tipo_persona
        {
            get
            {
                return tipo_persona;
            }

            set
            {
                tipo_persona = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
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

       
    }
}
