using System;

namespace iftstprj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte svuj rok narozeni: ");
            int.TryParse(Console.ReadLine(), out int rok);
            Console.Write("Zadejte mesic, v kterem jste se narodili: ");
            int.TryParse(Console.ReadLine(), out int mesic);
            Console.Write("Zadejte den, v kterem jste se narodili: ");
            int.TryParse(Console.ReadLine(), out int den);
            int rokVypocet = 2021 - rok;
            int mesicVypocet = 10 - mesic;
            int denVypocet = 9 - den;
            if (rokVypocet >= 18)
            {
                if (mesicVypocet >= 0)
                {
                    if (denVypocet >= 0)
                        Console.WriteLine("ano, mohl jit k volbam");
                    else
                        Console.WriteLine("Nemohl jit k volbam.");
                }
                else
                    Console.WriteLine("Nemohl jit k volbam.");
            }
            else
                Console.WriteLine("Nemohl jit k volbam.");
        }
    }
}