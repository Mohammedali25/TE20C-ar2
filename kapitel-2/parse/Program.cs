using System;

namespace parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du?");
            string ålder = Console.ReadLine();
            
            System.Console.WriteLine($"Du är (ålder) gammal");
// här så konventerar string från heltal
            int ålderTal = int.Parse(ålder);

            System.Console.WriteLine($"Du har {20 -ålderTal} år kvar tills du får gå på systemet");

            System.Console.WriteLine("hur mycket väger du?");
            float vikt = float.Parse(Console.ReadLine());
            Console.WriteLine($"Din vikt blir {vikt * 2.2} Lbs");

           float viktLbs = vikt *2.2f;

           //Formatera till en snygg utskrift
           string viktString = viktLbs.ToString("0.##");
           Console.WriteLine($"din vikt är {viktString} lbs").
        }
    }
}
