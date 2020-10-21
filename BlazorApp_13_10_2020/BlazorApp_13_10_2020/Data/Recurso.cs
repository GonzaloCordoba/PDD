using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_13_10_2020.Data
{
    public class Recurso
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}
