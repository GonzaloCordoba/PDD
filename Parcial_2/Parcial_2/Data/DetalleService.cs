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
    public class DetalleService
    {

        private DataContext context;

        public DetalleService(DataContext _context)
        {
            context = _context;
        }


        public async Task<List<Detalle>> GetAll(int Id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.GetAllDetalles(Id);
        }

        public async Task<Detalle> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");
            return await remoteService.GetDetalle(id);
        }


        public async Task<Detalle> Save(Detalle value)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            if (value.Id == 0)
            {
                await remoteService.CreateDetalle(value);
            }
            else
            {
                await remoteService.EditDetalle(value);
            }
            return value;
        }

        public async Task<Detalle> Remove(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:54565/api");

            return await remoteService.DeleteDetalle(id);
        }
















        /*
        public async Task<Detalle> Get(int id)
        {
            return await context.Detalle.Where(i => i.Id == id).SingleAsync();
        }
        
        public async Task<List<Detalle>> GetAll()
        {
            return await context.Detalle.ToListAsync();
        }
        

        public async Task<List<Detalle>> GetAll()
        {
            var remoteService = RestService.For<IRemoteService>("https://localhost:44366/api");

            return await remoteService.GetAllDetalles();
        }


        public async Task<Detalle> Save(Detalle value)
        {
            if (value.Id == 0)
            {
                await context.Detalle.AddAsync(value);
            }
            else
            {
                context.Detalle.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Detalle.Where(i => i.Id == id).SingleAsync();
            context.Detalle.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }




        /*
        public Detalle [] GetDatallesAsync()
        {
            Detalle[] res = new Detalleo[1];
            res[0] = new Usuario { int Id = 1, User = "U1", Clave = "C1" };
            
            return res;
        }
        */
        /*
        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recurso.ToListAsync();
        }


        public async Task<List<Tarea>> GetTarea()
        {
            return await context.Tarea.ToListAsync();
        }
        */

    }
}
