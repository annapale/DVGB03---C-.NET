using System.Diagnostics;
using System;

namespace Laboration1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("0. Close");
                Console.WriteLine("1. Skriva jämna heltal från 0 till 30");
                Console.WriteLine("2. Läser in ett tal från användaren, och skriver ut om talet är positivt, negativt eller lika med 0");
                Console.WriteLine("3. Läser in ett tal n, och sedan läser in n värden från användaren. Därefter ska programmet skriva ut det minsta och det största värdet.");
                Console.WriteLine("4. Läser in en text och skriver ut hur många gånger ordföljden AB finns i texten");
                Console.WriteLine("5. använder en vektor (array) för att ta emot 10 decimaltal, och sedan skriva ut medianen och medelvärdet på talen");
                Console.WriteLine("6.  tar emot två heltal och beräknar summan av dem");
                Console.WriteLine("7. tar emot en bokstav (char) och skriver ut om bokstaven är med i alfabetet eller inte");
                Console.WriteLine("8. Lottoprogramm");

                string menustr = Console.ReadLine();
                int menu = Int32.Parse(menustr);

                switch (menu)
                {
                    case 0:
                        run = false; 
                        break;

                    case 1:
                        for (int i = 0; i < 31; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 2:
                        string talstr = Console.ReadLine();


                }
            }
            
        }
    }
}
