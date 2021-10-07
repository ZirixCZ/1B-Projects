using System;

namespace trojúhelník
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            //tohle je strana A
            Console.WriteLine("zadejte stranu A");
            double A = double.Parse(Console.ReadLine());
        

            //console.writeline píše do konzole
            //rozdíl mezi double a string je, že v double ,můžeme psát desetinný čísla
            //double.Parse převádí string na double
            //console.readline čte co uživatel napsal do konzole 

            //tohle je strana B
            Console.WriteLine("zadejte stranu B");
            double B = double.Parse(Console.ReadLine());

            //tohle je strana C
            Console.WriteLine("zadejte stranu C");
            double C = double.Parse(Console.ReadLine());

            //if je podmínka 
            //else je všechno ostatní
            //else if je ostatní URČITÁ podmínka
            //zjistíme jestli to je trojúhelník nebo ne 
           
            if (A+ B > C && A + C > B && B + C > A)
            {
                Console.WriteLine("je to trojúhelník ");
            

            

            //zjistíme jestli je trojúhelník rovnostranný (jestli se a = b atd)
            if (A == B && B == C )
            {
                 Console.WriteLine("rovnostranný");
            }

           
            //zjistíme jestli je trojúhelník rovnoramenný (jestl se dvě strany rovnají )

            else if (A == B || B == C || C == A)
            {
                Console.WriteLine("rovnoramenný");
            }

            //zjistíme jestli je trojúhelník pravoúhlí (pomocí pythagorvy věty)
            if (A * A + B * B == C * C || A * A + C * C == B *B || B * B + C *C == A * A)
            {
                Console.WriteLine("trojúhelník je pravoúhlý");
            }
            
            //určujeme jestli je trojúhelník obecný nebo ne
             if (A != B || A != C || B != C)
            {
                Console.WriteLine("obecný");
            }

            }
           
            // jestli a+b < c (platí pro všechny strany) tak to není trojúhelník
            if (A + B < C || A + C < B || B + C < A)
            {
                Console.WriteLine("není to trojúhelník");
            }
           
           

            //program se zeptá jestli chcete pokračovat            
            Console.WriteLine("chcete pokračovat ano");
            string odp = Console.ReadLine();
            
            if (odp == "ano")
            {
                goto Start;
            }         
           


        }
    }
}
