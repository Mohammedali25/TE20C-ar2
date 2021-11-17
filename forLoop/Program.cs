using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine("Räkna 1 till 10");

            //for (int i = 1; i > 11; i++)
            //{
              //  System.Console.WriteLine($"loop nr{i}");
            //}
        System.Console.WriteLine("skriv ett meddelande");
        string meddelande = Console.ReadLine();
        
        for (int i = 0; i < meddelande.Length; i++)
        {
            System.Console.WriteLine(meddelande[i]);
        }
        }
    }
}
