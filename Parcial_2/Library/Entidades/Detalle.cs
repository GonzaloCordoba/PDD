using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        public String Fecha { get; set; }
        public string Tiempo { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        public int RecursoId { get; set; }
        public Recurso Recurso { get; set; }
    }
}
