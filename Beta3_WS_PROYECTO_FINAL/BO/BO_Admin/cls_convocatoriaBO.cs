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


        public int Id_convocatoria { get => id_convocatoria; set => id_convocatoria = value; }
        public string Nombre_convocatoria { get => nombre_convocatoria; set => nombre_convocatoria = value; }
        public DateTime Fecha_inicio_convocatoria { get => fecha_inicio_convocatoria; set => fecha_inicio_convocatoria = value; }
        public DateTime Fecha_fin_convocatoria { get => fecha_fin_convocatoria; set => fecha_fin_convocatoria = value; }
        public int Numero_equipos { get => numero_equipos; set => numero_equipos = value; }
        public bool Tipo_categoria { get => tipo_categoria; set => tipo_categoria = value; }
        public string Tipo_convocatoria { get => tipo_convocatoria; set => tipo_convocatoria = value; }
    }
}
