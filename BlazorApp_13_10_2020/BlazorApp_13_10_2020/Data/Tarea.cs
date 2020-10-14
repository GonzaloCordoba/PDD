using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp_13_10_2020.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int ResponsableId { get; set; }
     
        public Boolean Estado { get; set; }

    }
}

