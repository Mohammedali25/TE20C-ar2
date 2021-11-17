using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {
            //frågar om namnet och gör en variabel av den
            Console.Write("Vad heter du?");
            string namn = Console.ReadLine();
            // frågar om bruttolönen och gör den till en variabel
            Console.Write("ange din bruttolön i kronor");
            int bruttolön = int.Parse(Console.ReadLine());
            //ser till att personen får ett meddelande om bruttolönen är större än 45000 eller mindre än 10000
            if (bruttolön > 45000)
            {
                System.Console.WriteLine($"{namn}, bruttolön måste vara < 45000");
            }
            if (bruttolön < 10000)
            {
                System.Console.WriteLine($"{namn},bruttolön måste vara > 10000 kr");
            }
            else
            {
                // frågar om skattesatsen och gör den till en variabel 
                System.Console.Write("ange din skattesats i %");
                int skattesats = int.Parse(Console.ReadLine());
                // ser till att personen får ett meddelande om skattesatsen är över 45% eller mindre än 10%
                if (skattesats > 45)
                {
                    System.Console.WriteLine($"{namn}, skattesatsen måste vara <= 45%");
                }
                if (skattesats < 10)

                {
                    System.Console.WriteLine($"{namn}, skattesatsen måste vara >= 10%");

                }
                else
                {
                    // räkna ut nettolön
                    float nettolön = (bruttolön / skattesats);

                    System.Console.WriteLine($"{namn}, din nettolön blir {nettolön} kr.");
                    System.Console.WriteLine($"Baserat på bruttolön {bruttolön} kr och skattesatsen {skattesats}%.");
                }
            }
            {

            }
        }
    }
}
