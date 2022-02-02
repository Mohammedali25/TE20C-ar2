using System;

namespace slagsmålsspelet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slagsmålsspelet");
            while (true)
            {
                Console.WriteLine("Vad heter hjälten? ");
                string hjälten = Console.ReadLine();

                System.Console.WriteLine(hjälten.Length);
                if (hjälten.Length > 3 && hjälten.Length < 15)
                {
                    System.Console.WriteLine("Bra namn ");
                    break;
                }
                else
                {
                    System.Console.WriteLine("byt namn namnet ska vara större än 3 bokstäver och mindre än 15");
                }

            }

            string[] namnen = {
               "Frost",          //0
               "Jack",     //1
               "Fiddle" };      //2



            Random tärning = new Random();
            int fienden = tärning.Next(0, 2);
            //Gamestate för våra spelare

            int hjältenHP = 100;
            int fiendenHP = 100;

            //slump generator
            Random generator = new Random();


            //slagsmåls  loopen "Vi kör tills någon har =< 0 i HP"
            while (true)
            {
                //Slumpa fram ett slag för hjälten

                int slag = generator.Next(0, 21);

                //Själva slaget för hjälten

                hjältenHP -= slag;
                Console.WriteLine($"{hjälten} har nu {hjältenHP} HP");


                //Slumpa fram ett slag för fienden

                int slag2 = generator.Next(0, 21);

                //Själva slaget för fienden

                fiendenHP -= slag2;
                Console.WriteLine($"{fienden} har nu {fiendenHP} HP");

                if (fiendenHP <= 0 || hjältenHP <= 0)
                {
                    break;
                }
                //Pausa mellan slag 

                Console.ReadKey();

                //Vem vann eller blev det oavgjort

                if (hjältenHP > fiendenHP)
                {
                    Console.WriteLine($"{hjälten} krossade {fienden} ");
                }
                else if (fiendenHP > hjältenHP)
                {
                    Console.WriteLine($"{fienden} vann mot {hjälten}");
                }
                else
                {
                    Console.WriteLine("Matchen oavgjort...");
                }


            }

        }
    }
}
