using System;

namespace uppgift_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv din summa");
            string summaText = Console.ReadLine();
            int summa = 0;
            for (int i = 0; i < summaText.Length; i++)
            {
               char siffra = summaText[i];
                System.Console.WriteLine(summaText[i]);
           
           int siffraTal = int.Parse(siffra.ToString());

            summa += siffraTal;
            }
        }
    }
}
