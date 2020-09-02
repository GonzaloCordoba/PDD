using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            string mensaje = "Ingrese su año de nacimiento";
            IngresoAnio(mensaje, out anio);
            Console.WriteLine(EsAniobiciesto(ref anio));
            
            
        }
        static void IngresoAnio(string mensaje, out int anio) {
            Console.WriteLine(mensaje);
            anio= int.Parse(Console.ReadLine());
        }
        static string EsAniobiciesto( ref int anio)
        {
            if ((anio % 4 == 0) && (anio % 100 == 0) && (anio % 400 == 0))
            {
                return "Es biciesto";
            }
            else {
                return "No es biciesto";
            }
        }
    }
}
