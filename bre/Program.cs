using System;
using System.Diagnostics;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fraga = { "Vad heter frankrikes huvudstad?", "Vem vann melodifestivalen 2015?", "Vad firar svenskar på midsommar?", "Vad heter världens största djur?" };
            string[] rätt = { "Paris", "Måns Zelmerlöw", "Midsommar", "Blåval" };

            bool kör = true;

            while (kör = true)
            {
                Console.WriteLine("\nVälj mellan fråga 1-4");
                int val = int.Parse(Console.ReadLine());

                Console.WriteLine($"\n\nFråga {val}");
                Console.WriteLine(fraga[val - 1]);
                string svar = Console.ReadLine();

                if (svar == rätt[val - 1])
                {
                    Console.WriteLine("\nRätt!!!\n");
                }
                else
                {
                    Console.WriteLine("\nFel >:(\n");
                }

                Console.WriteLine("Vill du fortsätta? y/n");
                string fortsatta = Console.ReadLine();
                if (fortsatta == "y")
                {

                }
                else
                {
                    break;
                }
            }
            kör = false;
        }
    }
}
