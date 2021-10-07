using System;

namespace Tester08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hodnoty stran od uživatele
            Console.WriteLine("Zadejte hodnotu strany a v cm: ");
            string strA = Console.ReadLine();
            double a = int.Parse(strA);

            Console.WriteLine("Zadejte hodnotu strany b v cm: ");
            string strB = Console.ReadLine();
            double b = int.Parse(strB);

            Console.WriteLine("Zadejte hodnotu strany c v cm: ");
            string strC = Console.ReadLine();
            double c = int.Parse(strC);

            ///////// Podmínka o tom, jestli se jedná nebo nejedná o trojúhelník 
            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("\nJe to trojúhelník");
            }
            else
            {
                Console.WriteLine("\nNení to trojúhelník");
            }

            //////// 1. řešní - trojúhelníky
            if ((a == b || b == c || c == a) && (a != b && b != c))
            {
                Console.WriteLine("\nJe rovnoramenný");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("\nJe rovnostranný");
            }
            else if (c * c == a * a + b * b || a * a == b * b + c * c || b * b == a * a + c * c)
            {
                Console.WriteLine("\nJe pravoúhlý");
            }
            else
            {
                Console.WriteLine("\nJe obecný ");
            }


            //////// 2. řešní - trojúhelníky
            if (a == b && b == c)
            {
                Console.WriteLine("\nJe obecný");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("\nJe rovnostranný");
            }
            else if (c * c == a * a + b * b || a * a == b * b + c * c || b * b == a * a + c * c)
            {
                Console.WriteLine("\nJe pravoúhlý");
            }
            else
            {
                Console.WriteLine("\nJe rovnoramenný");
            }

            // Umocnění
            double pythHodA = Math.Pow(a, 2);
            double pythHodB = Math.Pow(b, 2);
            double pythHodC = Math.Pow(c, 2);

            // Podmínka na pyhagorovou větu
            if ((a > b && a > c))
            {
                Console.WriteLine($"{pythHodA} = {pythHodB} + {pythHodC}");
            }
            else if ((b > a && b > c))
            {
                Console.WriteLine($"{pythHodB} = {pythHodA} + {pythHodC}");
            }
            else
            {
                Console.WriteLine($"{pythHodC} = {pythHodB} + {pythHodA}");
            }

            
        }
    }
}
