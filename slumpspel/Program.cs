using System;

namespace slumpspel
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Clear();
            Console.WriteLine("Slumptal");
           //Slumpgenerator
            Random generator = new Random();

            //slumpa fram ett tal 1-10
            int slumptal = generator.Next(1,11);
            int slumptal2 = generator.Next(1,7);

            System.Console.WriteLine($"{slumptal} {slumptal2}");
        }
    }
}
