using System;

namespace Trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            Console.WriteLine("Zadej stranu A");
            double A = double.Parse(Console.ReadLine());
            //Uživatel zadá stranu A a zadaná hodnota se uloží do proměnné "A"
            
            Console.WriteLine("Zadej stranu B");
            double B = double.Parse(Console.ReadLine());
            //Uživatel zadá stranu B a zadaná hodnota se uloží do proměnné "B"

            Console.WriteLine("Zadej stranu C");
            double C = double.Parse(Console.ReadLine());
            //Uživatel zadá stranu C a zadaná hodnota se uloží do proměnné "C"


            if (A + B > C && A + C > B && B + C > A)
                //Pokud je možné trojuhelník sestrojit
            {

                if (A == B && A == C)
                    //Pokud se všechny strany rovnají, && znamená a
                {
                    string druh = ("rovnostranny");
                    //Proměnná druh která je string označuje rovnostranny
                    Console.WriteLine("Je to " + druh + " trojuhelnik");
                    //Console napíše Je to rovnostranny trojuhelnik (druh=rovnostranny viz řádek 31)
                    Console.WriteLine("Chces pokracovat? A/N");
                    string pokracovani = Console.ReadLine();
                    if (pokracovani == "A")
                    {
                        Console.WriteLine("");
                        goto Start;
                        //Vrátí se na začátek
                    }
                    else if (pokracovani == "N")
                    {
                        Environment.Exit(0);
                    }
                    
                }

                if (A == B || B == C || A == C)
                    //Pokud se alespoň 2 strany rovnají, || znamená nebo
                {
                    string druh = ("rovnoramenny");
                    Console.WriteLine("Je to " + druh + " trojuhelnik");
                    Console.WriteLine("Chces pokracovat? A/N");
                    string pokracovani = Console.ReadLine();
                    if (pokracovani == "A")
                    {
                        Console.WriteLine("");
                        goto Start;
                        //Vrátí se na začátek
                    }
                    else if (pokracovani == "N")
                    {
                        Environment.Exit(0);
                        //Konec
                    }
                } 
            
                
                if (A * A + B * B == C * C || B * B + C * C == A * A || A * A + C * C == B * B)
                   //Pokud platí Pythagorova věta
                {
                    string druh = ("pravouhly");
                    Console.WriteLine("Je to " + druh + " trojuhelnik");
                    Console.WriteLine("Chces pokracovat? A/N");
                    string pokracovani = Console.ReadLine();
                    if (pokracovani == "A")
                    {
                        Console.WriteLine("");
                        goto Start;
                    }
                    else if (pokracovani == "N")
                    {
                        Environment.Exit(0);
                    }
                }

                else
                    //Všechno ostatní
                {
                    string druh = ("obecny");
                    Console.WriteLine("Je to " + druh + " trojuhelnik");
                    Console.WriteLine("Chces pokracovat? A/N");
                    string pokracovani = Console.ReadLine();
                    if (pokracovani == "A")
                    {
                        Console.WriteLine("");
                        goto Start;
                    }
                    else if (pokracovani == "N")
                    {
                        Environment.Exit(0);
                    }
                }


            }
            else
            //Pokud není možné trojuhelník sestrojit
            {
                Console.WriteLine("Neni to trojuhelnik");
                Console.WriteLine("Chces pokracovat? A/N");
                string pokracovani = Console.ReadLine();
                if (pokracovani == "A")
                {
                    Console.WriteLine("");
                    goto Start;
                }
                else if (pokracovani == "N")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}

