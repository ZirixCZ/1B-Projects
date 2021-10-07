using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej stranu trojúhelníku a: ");//Konzole se ptá na hodnotu strany, aby s ní pak mohla pracovat.
            string zadanoA = Console.ReadLine();
            double a = double.Parse(zadanoA);//String je text, a tudíž s ním nemůžeme provádět početní operace a proto si ho převedeme na double(čísla).
            Console.WriteLine("Hodnota strany a je: " + a + " cm");

            Console.Write("Zadej stranu trojúhelníku b: ");
            string zadanoB = Console.ReadLine();
            double b = double.Parse(zadanoB);
            Console.WriteLine("Hodnota strany b je " + b + " cm");

            Console.Write("Zadejte stranu trojúhelníku c: ");
            string zadanoC = Console.ReadLine();
            double c = double.Parse(zadanoC);
            Console.WriteLine("Hodnota strany c je " + c + " cm");

            if ((a + b) > c && (a + c) > b && (b + c) > a)//Zde je podmínka, která nám ověřuje zda uživatel opravdu zadal trojúhelník. Ověřuje, že 2 sečtené strany jsou větší než ta 1, kterou nesčítáme.
            {
                Console.WriteLine("Je to trojúhelník");
            }
            else//Pokud se podmínka, že je to trojúhelník nesplňuje, tak konzole vypíše, že to není trojúhelník.
            {
                Console.WriteLine("Není to trojúhelník");
            }

            if ((a == b) && (b == c))//Další podmínka určuje zda je trojúhelník rovnostranný (všechny 3 strany se rovnají).
            {
                Console.WriteLine("Tento trojúhelník je rovnostranný");//Pokud ano, konzole to vypíše.
            }

            else if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))//Pokud ne, tak to pokračuje na další podmínku a to je jestli je trojúhelník pravoúhlý za pomoci pythagorovy věty.
            {
                Console.WriteLine("Tento trojúhelník je pravoúhlý");//Pokud to splňuje pythagorovu větu, konzole vypíše, že je trojúhelník pravoúhlý.
            }

            else if ((a == b) || (b == c) || (a == c))
            {
                Console.WriteLine("Tento trojúhelník je rovnoramenný");//Pokud to nesplňuje ani pythagorovu větu, tak to zkontroluje zda není trojúhelník robnoramenný (2 ramena jsou stejně dlouhá).
            }
            
            else
            {
                Console.WriteLine("Tento trojúhelník je obecný");//Pokud to nesplňuje ani 1 z podmínek konzole vypíše, že je trojúhelník obecný.
            }
            Console.ReadLine();
        }
    }
}