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
    public class TareaService
    {


        private DataContext context;

        public TareaService(DataContext _context)
        {
            context = _context;
        }

        public async Task<List<Tarea>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.GetAllTareas();
        }

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");
            return await remoteService.GetTarea(id);
        }


        public async Task<Tarea> Save(Tarea value)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            if (value.Id == 0)
            {
                await remoteService.CreateTarea(value);
            }
            else
            {
                await remoteService.EditTarea(value);
            }
            return value;
        }


        public async Task<Tarea> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.DeleteTarea(id);
        }

    }
}

