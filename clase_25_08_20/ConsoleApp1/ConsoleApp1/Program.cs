using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
            {
                int num = 12;
                int ingreso = 0;
                
                while(ingreso!=num){
                    Console.WriteLine("Adivene el numero:");
                    ingreso = int.Parse(Console.ReadLine());
                    if (ingreso == num){
                        Console.WriteLine("Ganaste");
                    }
                    else {
                        Console.WriteLine("Siga intentando");
                    }
                    
                }
                    
        }
    }
}
