using System;

namespace iftstprj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte cislo A: ");
            int.TryParse(Console.ReadLine(), out int A);
            Console.Write("Zadejte cislo B: ");
            int.TryParse(Console.ReadLine(), out int B);
            Console.Write("Zadejte cislo C: ");
            int.TryParse(Console.ReadLine(), out int C);
            Console.Write("Zadejte cislo D: ");
            int.TryParse(Console.ReadLine(), out int D);
            int F = D;
            int O = A;
            int H = B;
            
            A = F;
            D = O;

            B = C;
            C = H;
            Console.WriteLine($"Nove uskupeni: A je {A}, B je {B}, C je {C}, D je {D}");
        }
    }
}