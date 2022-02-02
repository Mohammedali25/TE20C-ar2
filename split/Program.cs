using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ord");

            System.Console.WriteLine("Ange en mening:");

            string mening = Console.ReadLine();
            
            string[] orden = mening.Split(" ");

            foreach (var ord in orden)
            {
                System.Console.WriteLine(ord);
            }
        System.Console.WriteLine($"Antal ord i mening är {mening.Length}");

        string nyMening = string.Join('/',orden);

        System.Console.WriteLine(nyMening);
      
        }
    }
}
