using System;

namespace Projekt_trojúhelník
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            urcenistran:

            Console.WriteLine("Zadejte stranu a.");
            string a0 = Console.ReadLine();
            double a = double.Parse(a0);

            Console.Clear();

            Console.WriteLine("Zadejte stranu b.");
            string b0 = Console.ReadLine();
            double b = double.Parse(b0);

            Console.Clear();

            Console.WriteLine("Zadejte stranu c. (Nesmí být větší než {0} a musí být větší než {1})",(a+b),Math.Max(a,b)-Math.Min(a,b));
            string c0 = Console.ReadLine();
            double c = double.Parse(c0);
            
            Console.Clear();

            double max0 = Math.Max(a, b);
            double max = Math.Max(max0, c);

            double a2 = Math.Pow(a, 2); // mocniny
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);
            
            
            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
               
            }
            else
            {
                Console.WriteLine("Toto není trojúhelník, zadejte znovu strany.");
                goto urcenistran;
            }
            if (a == b && a == c)
            {
                Console.WriteLine("Trojúhelník je rovnostranný.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Trojúhelník je rovnoramenný.");
            }

            if (max == a)
            {
                if ((b2 + c2) == a2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }

            }
            else if (max == b)
            {
                if ((a2 + c2) == b2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }
            }
            else if (max == c)
            {
                if ((a2 + b2) == c2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }
                
            }
            if ((a2+b2) != c2 && (a2 + c2) != b2 && (c2 + b2) != a2 && a != b && a != c && b != c) 
            {
                Console.WriteLine("Trojúhelník je obecný.");
            }
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key);



        }
    }
}
