using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using Library.Entidades;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuarioController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Usuario> GetAll()
        {
            return _context.Usuario.ToList();
        }


        [HttpGet("{id}")]

        public Usuario Get(int id)
        {
            Usuario usuario = _context.Usuario.Where(i => i.Id == id).SingleOrDefault();
            return usuario;
        }

        [HttpPut]
        public Usuario EditUsuario(Usuario value)
        {
            Usuario usuarioeditar = _context.Usuario.Find(value.Id);
            usuarioeditar.Clave = value.Clave;
            usuarioeditar.Nombre = value.Nombre;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Usuario CreateUsuario(Usuario value)
        {
            _context.Usuario.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Usuario DeleteUsuario(int id)
        {
            Usuario usuarioborrar = _context.Usuario.Find(id);
            _context.Usuario.Remove(usuarioborrar);
            _context.SaveChanges();
            return usuarioborrar;
        }
    }
}
