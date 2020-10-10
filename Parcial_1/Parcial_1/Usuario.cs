using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial_1
{
    class Usuario
    {
        public int Id { get; set; }
        [MaxLength(15)]
        [MinLength(3)]
        public String Nombre { get; set; }
        [Required]
        [MaxLength(8)]
        public String Clave { get; set; }
    }
}
