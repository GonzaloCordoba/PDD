using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;    

namespace BlazorApp_13_10_2020.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=tareas.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Usuario>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Recurso>().ToTable("Recurso");
            modelBuilder.Entity<Recurso>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Recurso>().Property(p => p.Nombre).HasMaxLength(30).IsRequired();

            modelBuilder.Entity<Tarea>().ToTable("Tarea");
            modelBuilder.Entity<Tarea>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Tarea>().Property(p => p.Titulo).HasMaxLength(25).IsRequired();
            modelBuilder.Entity<Tarea>().Property(p => p.Vencimiento).IsRequired();
            modelBuilder.Entity<Tarea>().Property(p => p.Estado).HasDefaultValue(false);

            modelBuilder.Entity<Detalle>().ToTable("Detalle");
            modelBuilder.Entity<Detalle>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Detalle>().Property(p => p.Fecha).IsRequired();
            modelBuilder.Entity<Detalle>().Property(p => p.Tiempo).IsRequired();

        }
        public DbSet<Detalle> Detalle { get; set; }
        public DbSet<Tarea> Tarea { get; set; }
        public DbSet<Recurso> Recurso { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
