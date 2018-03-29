using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    public class cls_personaBO
    {
        private int matricula_persona;
        private string nombre_persona;
        private string apePat_persona;
        private string apeMar_persona;
        private string correoElect_persona;
        private int telefono_persona;
        private double genero_persona;
        private int id_equipo;
        private int id_convocatoria;


        public int Matricula_persona { get => matricula_persona; set => matricula_persona = value; }
        public string Nombre_persona { get => nombre_persona; set => nombre_persona = value; }
        public string ApePat_persona { get => apePat_persona; set => apePat_persona = value; }
        public string ApeMar_persona { get => apeMar_persona; set => apeMar_persona = value; }
        public string CorreoElect_persona { get => correoElect_persona; set => correoElect_persona = value; }
        public int Telefono_persona { get => telefono_persona; set => telefono_persona = value; }
        public double Genero_persona { get => genero_persona; set => genero_persona = value; }
        public int Id_equipo { get => id_equipo; set => id_equipo = value; }
        public int Id_convocatoria { get => id_convocatoria; set => id_convocatoria = value; }
    }
}
