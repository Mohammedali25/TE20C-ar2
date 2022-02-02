using System;

namespace kapitel_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("slumpa fram en fråga");

           string[] korten = {
               "När uppgfördes Verdi?",          //0
               "Vem vann fotbolls-EM 1984?",     //1
               "Vem skrev Frankenstein?",        //2
               "Vad är 5+5",                     //3
               "När startade andra världskriget",//4
               "Vem är president i USA 2021"};   //5
           
            Random tärning = new Random();
            int slumptal = tärning.Next(0,6);

            Console.WriteLine($"Tärningen slog {slumptal}");
        
        System.Console.WriteLine($"Fråga 2: {korten[slumptal]}");


        }
    }
}
