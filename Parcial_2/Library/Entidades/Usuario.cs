using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Entidades
{
    public class Usuario
    {
        public Usuario() { }
        public Usuario(int Id, string Nombre, string Clave)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Clave = Clave;
        }

        public int Id { get; set; }
        [MaxLength(15)]
        [MinLength(3)]
        public String Nombre { get; set; }
        [Required]
        [MaxLength(8)]
        public String Clave { get; set; }
    }
}
