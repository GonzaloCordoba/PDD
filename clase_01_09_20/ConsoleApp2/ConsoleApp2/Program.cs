    using System;

namespace ConsoleApp2
{
    class Program
    {
                static void Main(string[] args)
                {
                    int chances = 0;
                    int ingreso;

                    Random random = new Random();
                    int secreto = random.Next(10);

                    do
                    {
                        Console.WriteLine("Adivene el numero:");
                        ingreso = int.Parse(Console.ReadLine());
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
                    static void Ganaste() {
                        Console.WriteLine("Ganaste!!");
                    }
                    static void Perdiste(int valor)
                    {
                        Console.WriteLine("Perdiste! el numero secreto es:" + valor);
                    }
    }
}
