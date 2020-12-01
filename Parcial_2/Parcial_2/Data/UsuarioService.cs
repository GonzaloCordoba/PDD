using Microsoft.EntityFrameworkCore;
using Library.Entidades;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;

namespace Parcial_2.Data
{
    public class UsuarioService
    {


        private DataContext context;

        public UsuarioService(DataContext _context)
        {
            context = _context;
        }

        public async Task<Usuario> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");
            return await remoteService.GetUsuario(id);
        }


        public async Task<List<Usuario>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.GetAll();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            if (value.Id == 0)
            {
                await remoteService.CreateUsuario(value);
            }
            else
            {
                await remoteService.EditUsuario(value);
            }
            return value;
        }


        public async Task<Usuario> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.DeleteUsuario(id);
        }



    }
}