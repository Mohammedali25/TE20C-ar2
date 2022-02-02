using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uppgift 5.1");

            
            int[] heltal = new int[6];

            heltal[0] = 1;
            heltal[1] = 2;
            heltal[2] = 3;
            heltal[3] = 4;
            heltal[4] = 5;
            heltal[5] = 6;
             
            int summa = 0;
            foreach (var tal in heltal)
            {
                summa += tal;
            }

        }
    }
}
