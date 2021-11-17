using System;

namespace lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lyckohjul");
            Random generator = new Random();

            // Skapa ett program som ska fungera som ett lyckohjul

            //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
            
            
            //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
           
            //Berätta också för användaren om hen vann eller förlorade
            for (int i = 0; i < 3; i++)
            {
            System.Console.WriteLine("välj ett tal mellan 1-10");
            int gissning = int.Parse(Console.ReadLine());
            
                 int Tal = generator.Next(1, 11);
            
                if (Tal == gissning)
                {
              System.Console.WriteLine($"{Tal}");
                System.Console.WriteLine("Grattis du vann");
                }
                else
                {
              System.Console.WriteLine($"{Tal}");
               System.Console.WriteLine("du förlorade försök igen");
                }
            }
        }
    }
}

            //Användaren får 3 försök!



           