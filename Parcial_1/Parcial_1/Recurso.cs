using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial_1
{
    class Recurso
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
 
    }
}
