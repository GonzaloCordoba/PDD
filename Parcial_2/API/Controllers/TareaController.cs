﻿using System;
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
    public class TareaController : ControllerBase
    {
        private readonly DataContext _context;

        public TareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public List<Tarea> GetAllTareas()
        {
            return _context.Tarea.ToList();
        }


        [HttpGet("{id}")]

        public Tarea GetTarea(int id)
        {
            Tarea tarea = _context.Tarea.Where(i => i.Id == id).SingleOrDefault();
            return tarea;
        }

        [HttpPut]
        public Tarea EditTarea(Tarea value)
        {
            Tarea tareaeditar = _context.Tarea.Find(value.Id);
            tareaeditar.Titulo = value.Titulo;
            tareaeditar.Vencimiento = value.Vencimiento;
            tareaeditar.Estimacion = value.Estimacion;
            tareaeditar.ResponsableId = value.ResponsableId;
            tareaeditar.Estado = value.Estado;
            _context.SaveChanges();
            return value;
        }

        [HttpPost]
        public Tarea CreateTarea(Tarea value)
        {
            _context.Tarea.Add(value);
            _context.SaveChanges();
            return value;
        }


        [HttpDelete("{id}")]
        public Tarea DeleteTarea(int id)
        {
            Tarea tareaborrar = _context.Tarea.Find(id);
            _context.Tarea.Remove(tareaborrar);
            _context.SaveChanges();
            return tareaborrar;
        }
    }
}
