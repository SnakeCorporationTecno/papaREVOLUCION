using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    class cls_torneoBO
    {
        private int id_torneo;
        private string nombre_torneo;
        private DateTime fecha_inicio_torneo;
        private DateTime fecha_fin_torneo;
        private int num_equipos_torneo;
        private int id_convocatoria;


        public int Id_torneo { get => id_torneo; set => id_torneo = value; }
        public string Nombre_torneo { get => nombre_torneo; set => nombre_torneo = value; }
        public DateTime Fecha_inicio_torneo { get => fecha_inicio_torneo; set => fecha_inicio_torneo = value; }
        public DateTime Fecha_fin_torneo { get => fecha_fin_torneo; set => fecha_fin_torneo = value; }
        public int Num_equipos_torneo { get => num_equipos_torneo; set => num_equipos_torneo = value; }
        public int Id_convocatoria { get => id_convocatoria; set => id_convocatoria = value; }
    }
}
