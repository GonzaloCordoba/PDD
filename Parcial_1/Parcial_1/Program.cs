using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertarUsuarios();
            ConsultarUsuarios();
            //ActualizarUsuarios();
            //BorrarUsuarios();
        }
        static void InsertarUsuarios()
        {
            var ctx = new TareasDbContext();
            ctx.Usuario.Add(new Usuario { Nombre = "Gonzalo", Clave = "1111" });

            ctx.Add(new Usuario() { Nombre = "Camila", Clave = "2222" });
            ctx.Add(new Usuario() { Nombre = "Paula", Clave = "3333" });
            ctx.Add(new Usuario() { Nombre = "Damian", Clave = "1111" });
            ctx.Add(new Usuario() { Nombre = "Paloma", Clave = "4444" });


            ctx.SaveChanges();
        }

        static void ActualizarUsuarios()
        {

            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.Where(i => i.Id == 1).ToList();
            lista[0].Nombre = "Marianela";

            ctx.SaveChanges();

        }

        static void BorrarUsuarios()
        {
            var ctx = new TareasDbContext();

            var user = ctx.Usuario.Where(i => i.Id == 5).Single();
            ctx.Usuario.Remove(user);

            ctx.SaveChanges();
        }

        static void ConsultarUsuarios()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuario.ToList();
            foreach (var users in lista)
            {
                //Console.WriteLine($"Nombre: {users.Nombre} ({users.Id}) ({users.Clave})");
                Console.WriteLine("ID: " + users.Id + " \nNombre: " + users.Nombre + " \nClave: " + users.Clave + "\n-----------------");
            }
        }
    }
}
