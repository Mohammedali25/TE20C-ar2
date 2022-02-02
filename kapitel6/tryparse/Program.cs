using System;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gissa ett tal");

            Random generator = new Random();

            int slumptal = generator.Next(1, 101);
            int slumptal2 = generator.Next(1,11);

            System.Console.WriteLine("Gissa ett tal (1-100): ");
           string gissning = Console.ReadLine();
            int gissningTal = 0;
           bool korrekt = false;
           while (korrekt != true)
            int.TryParse(gissning, out gissningTal);
            
            if (gissningTal == slumptal)
            {
                System.Console.WriteLine("du gissade rätt");
            }
            else
            {
               System.Console.WriteLine("du gissade fel"); 
            }
        }
    }
}
