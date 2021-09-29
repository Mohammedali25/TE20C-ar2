using System;

namespace övning._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("mata in 3 löner");
          int lön1 = int.Parse(Console.ReadLine());
          int lön2 = int.Parse(Console.ReadLine());
          int lön3 = int.Parse(Console.ReadLine());
        // Räkna ut medelvärdet
        float medelvärde = (lön1 + lön2 + lön3) / 3;
         // Skriv ut resultatet
         System.Console.WriteLine("Medelvärdet är {medelvärde}");
        }
    }
}
