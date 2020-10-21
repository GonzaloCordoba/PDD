using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_13_10_2020.Data
{
    public class UsuarioService
    {
        private DataContext context;

        public UsuarioService(DataContext _context) {
            context = _context;
        }

        public async Task<List<Usuario>> getAll() {
            return await context.Usuario.ToListAsync();
        }
    }
}
