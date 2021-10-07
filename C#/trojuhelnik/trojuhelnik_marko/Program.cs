using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jmeno_Prijmeni_1B_Trojuhelnik.pdf | josef.horalek@delta-skola.cz | powerpoint dokumentace
            //do stredy rano

            //Zadani stran od uzivatele
            Console.Write("Zadejte stranu a: ");
            string inputa = Console.ReadLine();
            Console.Write("Zadejte stranu b: ");
            string inputb = Console.ReadLine();
            Console.Write("Zadejte stranu c: ");
            string inputc = Console.ReadLine();

            //Prevadeni stringu na double
            double a = double.Parse(inputa);
            double b = double.Parse(inputb);
            double c = double.Parse(inputc);

            //Prevence aby uzivatel nemohl zadat hodnotu '0'
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Nelze zadat hodnota 0!");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }

            //Urceni maximalniho cisla
            double max = Math.Max(Math.Max(a, b), c);

            //List pro pouziti dale v kodu na vypocitani pytagorovy vety
            List<double> strany = new List<double>();
            strany.Add(a - max);
            strany.Add(b - max);
            strany.Add(c - max);

            //Urceni toho jestli je to trojuhelnik
            if (a + b > c && c + b > a && a + c > b)
            {
                Console.Write("Je to trojuhelnik");
                //Urceni toho jestli je trojuhelnik rovnostranny
                if (a == c && c == b && c == a)
                {
                    Console.Write(" rovnostranny!");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                }
                //Urceni toho jestli je trojuhlenik rovnoramenny
                if (a + b + c - max == 2 * a || a + b + c - max == 2 * b || Math.Equals(a, b) || Math.Equals(b, c) || Math.Equals(c, a))
                {
                    Console.Write(" rovnoramenny!");
                    Console.ReadLine();
                    Console.Clear();
                    Main(args);
                }
                //Tato podminka je vzdycky pravda, zahajuje urceni Pytagorovy vety (jestli je pravouhly)
                if (strany.Contains(0))
                {
                    if (strany[0] == 0)
                    {
                        strany[1] = strany[1] + max;
                        strany[2] = strany[2] + max;
                        if (Math.Pow(strany[1], 2) + Math.Pow(strany[2], 2) == Math.Pow(max, 2))
                        {
                            Console.WriteLine(" pravouhly!");
                            Console.ReadLine();
                            Console.Clear();
                            Main(args);
                        }
                    }
                    if (strany[1] == 0)
                    {
                        strany[0] = strany[0] + max;
                        strany[2] = strany[2] + max;
                        if (Math.Pow(strany[0], 2) + Math.Pow(strany[2], 2) == Math.Pow(max, 2))
                        {
                            Console.WriteLine(" pravouhly!");
                            Console.ReadLine();
                            Console.Clear();
                            Main(args);
                        }
                    }
                    if (strany[2] == 0)
                    {
                        strany[1] = strany[1] + max;
                        strany[0] = strany[0] + max;
                        if (Math.Pow(strany[0], 2) + Math.Pow(strany[1], 2) == Math.Pow(max, 2))
                        {
                            Console.WriteLine(" pravouhly!");
                            Console.ReadLine();
                            Console.Clear();
                            Main(args);
                        }
                    }
                }
                Console.WriteLine("!");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
            //Napise ze to neni trojuhelnik v pripade spatne zadanych hodnot
            else
            {
                Console.WriteLine("Neni to trojuhelnik!");
                Console.ReadLine();
                Console.Clear();
                Main(args);
            }
            Console.ReadLine();
        }
    }
}
