using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al Reto 1... POO");

            Automovil auto = new Automovil("Blanco", "BMW", "X5 M Forza Edition", 2011, 700, 25000.00);
            auto.rodar();

        }
    }
}