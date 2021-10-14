using System;

namespace iftstprj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte cislo: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("Zadejte delitele: ");
            int.TryParse(Console.ReadLine(), out int delitel);

            int deleniCelo = number1 / delitel;
            
            Console.WriteLine($"vysledek deleni je {deleniCelo}.");
            
            

            if (number1 % delitel == 0)
                Console.WriteLine("zadane cislo je delitelne bezezbytku");
            else
            {
                int zbytek = number1 % delitel;
                Console.WriteLine($"zbytek po deleni je {zbytek}");
            }
        }
    }
}