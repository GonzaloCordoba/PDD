using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorApp_13_10_2020.Data
{
    public class Usuario
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
