using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            string odpoved;
            int uzivatel;
            bool vysledek;
            int spravne = 0;
            int spatne = 0;
            string operace;
            Random generator = new Random();

            
           while (true)
            {
                Console.WriteLine("Jaký typ příkladů chcete? +, -, *");
                operace = Console.ReadLine();

                if (operace == "*")
                {
                    do
                    {
                        Console.Clear();
                        int cisloA = generator.Next(1, 11);
                        int cisloB = generator.Next(1, 11);
                        Console.WriteLine("Jaký je výsledek rovnice " + cisloA + " * " + cisloB);
                        //uzivatel = int.Parse(Console.ReadLine());

                        while (!int.TryParse(Console.ReadLine(), out uzivatel))
                        {
                            Console.WriteLine("Musíš zadat číslo");
                        }
                        vysledek = (cisloA * cisloB) == uzivatel;

                        if (vysledek)
                        {
                            Console.WriteLine("Správná odpověď");
                            spravne++;
                        }
                        else
                        {
                            Console.WriteLine("Chybná odpověď");
                            spatne++;
                        }
                        Console.WriteLine("Chceš pokračovat? a/n");
                        odpoved = Console.ReadLine().ToUpper();
                    }
                    while (odpoved == "A");
                }
                else if (operace == "+")
                {
                    do
                    {
                        Console.Clear();
                        int cisloA = generator.Next(1, 11);
                        int cisloB = generator.Next(1, 11);
                        Console.WriteLine("Jaký je výsledek rovnice " + cisloA + " + " + cisloB);
                        //uzivatel = int.Parse(Console.ReadLine());

                        while (!int.TryParse(Console.ReadLine(), out uzivatel))
                        {
                            Console.WriteLine("Musíš zadat číslo");
                        }
                        vysledek = (cisloA + cisloB) == uzivatel;

                        if (vysledek)
                        {
                            Console.WriteLine("Správná odpověď");
                            spravne++;
                        }
                        else
                        {
                            Console.WriteLine("Chybná odpověď");
                            spatne++;
                        }
                        Console.WriteLine("Chceš pokračovat? a/n");
                        odpoved = Console.ReadLine().ToUpper();
                    }
                    while (odpoved == "A");
                }
                else if (operace == "-")
                {
                    do
                    {
                        Console.Clear();
                        int cisloA = generator.Next(1, 11);
                        int cisloB = generator.Next(1, 11);
                        Console.WriteLine("Jaký je výsledek rovnice " + cisloA + " - " + cisloB);
                        //uzivatel = int.Parse(Console.ReadLine());

                        while (!int.TryParse(Console.ReadLine(), out uzivatel))
                        {
                            Console.WriteLine("Musíš zadat číslo");
                        }
                        vysledek = (cisloA - cisloB) == uzivatel;

                        if (vysledek)
                        {
                            Console.WriteLine("Správná odpověď");
                            spravne++;
                        }
                        else
                        {
                            Console.WriteLine("Chybná odpověď");
                            spatne++;
                        }
                        Console.WriteLine("Chceš pokračovat? a/n");
                        odpoved = Console.ReadLine().ToUpper();
                    }
                    while (odpoved == "A");
                }
                Console.WriteLine("Počet správných odpovědí: " + spravne + " počet chybných odpovědí: " + spatne);

            }
                

            Console.ReadKey();
        }
    }
}
