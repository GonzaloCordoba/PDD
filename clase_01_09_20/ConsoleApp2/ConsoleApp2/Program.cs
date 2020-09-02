    using System;

namespace ConsoleApp2
{
    class Program
    {
                static void Main(string[] args)
                {
                    int chances = 0;
                    int ingreso = 0;

                    Random random = new Random();
                    int secreto = random.Next(10);

                    do
                    {
                        string mensaje = "Ingrese el numero";
                        Ingreso(mensaje, ref ingreso);
                        chances++;
                        if (ingreso == secreto)
                        {
                            Ganaste();
                            chances = 0;
                        }
                        else if(chances == 3)
                        {
                            Perdiste(secreto);
                        }

                    } while (ingreso != secreto && chances < 3);

          
                }
                static void Ganaste()
                {
                    Console.WriteLine("Ganaste!!");
                }
                static void Perdiste(int valor)
                {
                    Console.WriteLine("Perdiste! el numero secreto es: " + valor);
                }
                static void Ingreso(string mensaje, ref int ingreso)
                {
                    Console.WriteLine(mensaje);
                    ingreso = int.Parse(Console.ReadLine());
                }

    }
}
