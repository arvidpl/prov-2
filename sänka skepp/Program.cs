using System;

namespace sänka_skepp 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool färdig = false;

            while(färdig == false)
            {
                Spel();

                Console.WriteLine("Vill du spela igen? " + "Skriv R");

                string restart = Console.ReadLine();

                if (restart == "R")
                {
                    Spel();
                }
            }

        }

        static void Spel()
        {
            Console.WriteLine("VÄLKOMMEN TILL SÄNKA SKEPP!");

            bool klar = false;

            int koordinat = 16;

            while(klar == false)
            {
            Console.WriteLine("Skriv in en koordinat " + "[1-20]");

            int försök = int.Parse(Console.ReadLine());

            if (försök == koordinat)
            {
                Console.WriteLine("Hit!");

                klar = true;
            }

            else
            {
                Console.WriteLine("Miss!");
            }

        }
    }
} 
}