using Microsoft.EntityFrameworkCore;
using System;
using Library.Entidades;
using Refit;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;

namespace Parcial_2.Data
{
    public class RecursoService
    {

        private DataContext context;

        public RecursoService(DataContext _context)
        {
            context = _context;
        }


        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");
            return await remoteService.GetRecurso(id);
        }


        public async Task<List<Recurso>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.GetAllRecursos();
        }

        public async Task<Recurso> Save(Recurso value)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            if (value.Id == 0)
            {
                await remoteService.CreateRecurso(value);
            }
            else
            {
                await remoteService.EditRecurso(value);
            }
            return value;
        }


        public async Task<Recurso> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.DeleteRecurso(id);
        }


        public async Task<List<Usuario>> GetUsuarios()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.GetAll();
        }



    }
}
