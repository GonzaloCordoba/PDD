using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entidades
{
    public class Tarea
    {
        public Tarea() { }
        public Tarea(int Id, string Titulo, string Vencimiento, string Estimacion, int ResponsableId,Recurso Responsable ,bool Estado)
        {
            this.Id = Id;
            this.Titulo = Titulo;
            this.Vencimiento = Vencimiento;
            this.Estimacion = Estimacion;
            this.ResponsableId = ResponsableId;
            this.Responsable = Responsable;
            this.Estado = Estado;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Vencimiento { get; set; }
        public string Estimacion { get; set; }
        public int ResponsableId { get; set; }
        public Recurso Responsable { get; set; }
        public Boolean Estado { get; set; }
    }
}
