using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._10._2021
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Zadejte hodnotu strany A");
            string ZadanaA = Console.ReadLine();
            Console.WriteLine("Zadejte hodnotu strany B");
            string ZadanaB = Console.ReadLine();
            Console.WriteLine("Zadejte hodnotu strany C");
            string ZadanaC = Console.ReadLine();
            double StranaA = double.Parse(ZadanaA);
            double StranaB = double.Parse(ZadanaB);
            double StranaC = double.Parse(ZadanaC);
            double StranaA2 = Math.Pow(StranaA, 2);
            double StranaB2 = Math.Pow(StranaB, 2);
            double StranaC2 = Math.Pow(StranaC, 2);
            if (StranaA + StranaB > StranaC)
            {

                if (StranaA + StranaC > StranaB)
                {

                    if (StranaB + StranaC > StranaA)
                    {

                        Console.WriteLine("Zadaný strany souhlasí s podmínkami trojúhelníku.");
                    }

                    else
                    {

                        Console.WriteLine("Zadaný strany nesouhlasí s podmínkami trojúhelníku.");
                    }
                }
                else
                {
                    Console.WriteLine("Zadaný strany nesouhlasí s podmínkami trojúhelníku.");
                }


            }
            else
            {
                Console.WriteLine("Zadaný strany nesouhlasí s podmínkami trojúhelníku.");
            }
            if (StranaA == StranaB && StranaA == StranaC)
            {
                Console.WriteLine("Trojúhelník je rovnostranný.");
            }
            else
            {
                if (StranaA == StranaB || StranaA == StranaC || StranaB == StranaC)
                {
                    Console.WriteLine("Trojúhelník je rovnoramenný.");
                }
                else
                {
                    if (StranaC2 == StranaA2 + StranaB2 || StranaB2 == StranaA2 + StranaC2 || StranaA2 == StranaB2 + StranaC2)
                    {
                        Console.WriteLine("Trojúhelník je pravoúhlý");
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník je různostranný.");
                    }
                    
                }
            }
            Console.ReadLine();
        }
	}
}
