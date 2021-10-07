using System;

namespace troj_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && c + b > a) //Zkontrolujte, zda dané strany mohou tvořit trojúhelník
            {
                Console.WriteLine("to je troj");

                if ( a == b && a == c) //Zkontroluji, zda jsou všechny strany stejné
                {
                    Console.WriteLine("to je rovnostrany troj"); 
                }

                else if (a == b || a == c || b == c) //Zkontroluji, zda jsou alespoň 2 strany stejné
                {
                    Console.WriteLine("to je rovnorameny troj"); 
                }

                else if (a*a == b*b + c*c || b*b == a*a + c*c || c*c == a*a + b*b) //podle vzorce zkontrolujte, zda strany mohou tvořit pravoúhlý trojúhelník
                {
                    Console.WriteLine("to je pravouhly troj"); 
                }

                else //Pokud nic výše není pravda, pak je tento trojúhelník obyčejný
                {
                    Console.WriteLine("to je obycejny troj");
                }
            }
            else //pokud dané strany nemohou tvořit trojúhelník, pak:
            {
                Console.WriteLine("to je neni troj");
            }
        }
    }
}
