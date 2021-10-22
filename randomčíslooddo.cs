using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadejte číslo od ");
            int odc = int.Parse(Console.ReadLine());

            Console.WriteLine("zadejte číslo do");
            int doc = int.Parse(Console.ReadLine());

            Random rc = new Random();
            int cislo = rc.Next( odc, doc);

            Console.WriteLine(cislo);


        }
    }
}
