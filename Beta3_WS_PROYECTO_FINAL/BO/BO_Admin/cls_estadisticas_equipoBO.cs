﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beta3_WS_PROYECTO_FINAL.BO
{
    public class cls_estadisticas_equipoBO
    {
        private int id_estadiscicas;
        private int id_equipo;

        public int Id_estadiscicas
        {
            get
            {
                return id_estadiscicas;
            }

            set
            {
                id_estadiscicas = value;
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
