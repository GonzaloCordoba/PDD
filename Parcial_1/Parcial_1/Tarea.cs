﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_1
{
    class Tarea
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int ResponsableId { get; set; }  
        public Recurso Responsable { get; set; }
        public Boolean Estado { get; set; }

    }
}
