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
            Console.WriteLine(EsAniobiciesto(anio));
            
            
        }
        static void IngresoAnio(string mensaje, out int anio) {
            Console.WriteLine(mensaje);
            anio= int.Parse(Console.ReadLine());
        }
        static Boolean EsAniobiciesto(int anio)
        {
            if ((anio % 400 == 0))
            {
                return true;
            }
            if((anio % 4 == 0) && (anio % 100 != 0)){
                return true;
            }
            else {
                return false;
            }
        }
    }
}
