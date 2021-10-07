using System;

namespace projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej stranu a trojúhelníku ");
            string stranaa = Console.ReadLine();                   // načte stranu a
            double a = double.Parse(stranaa);
            Console.Clear();

            Console.WriteLine("Zadej stranu b trojúhelníku");    
            string stranab = Console.ReadLine();                    // načte stranu b
            double b = double.Parse(stranab);
            Console.Clear();

            Console.WriteLine("Zadej stranu c trojúhelníku");      // načte stranu c
            string stranac = Console.ReadLine();
            double c = double.Parse(stranac);
            Console.Clear();
            if ((a + b) > c)
            {
                
                   if ((b + c) > a)
                   {
                        if ((c + a) > b)
                        {    
                        Console.WriteLine("trojúhelník");
                        }
                        else
                        {
                            Console.WriteLine("není");
                        }
                   }
                   else
                   {
                        Console.WriteLine("není");
                   }
            }
            else
            
            {
                Console.WriteLine("není");
            }

            if (a == b && a == c)
            {
                Console.Write("trojúhelník je rovnostraný");
            }
            else if (a == b || b == c || c == a)
            {
                Console.Write("trojúhelník je rovnoramený");
            }
            double a2 = Math.Pow(a,2);
            double b2 = Math.Pow(b,2);
            double c2 = Math.Pow(c,2);

            if (c2 == (a2 + b2) || b2 == (a2 + c2) || a2 == (b2 + c2))
            {
                Console.Write("trojúhelník je pravoúhlý");
            }
            else
            {
                Console.Write("není");
            }



        }
    }
}
