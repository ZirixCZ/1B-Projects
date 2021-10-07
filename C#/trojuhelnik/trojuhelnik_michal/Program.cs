using System;
using System.Collections.Generic;

namespace prj_trojuhelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            // vytvoření promněnných zvnějšku do,while loopu  
            bool checker1, checker2, checker3;
            double strana1, strana2, strana3;
            while (true)
            {
                do
                {
                    Console.WriteLine("\nNapiste tri cisla, prosim.");
                    checker1 = double.TryParse(Console.ReadLine(), out strana1);
                    checker2 = double.TryParse(Console.ReadLine(), out strana2);
                    checker3 = double.TryParse(Console.ReadLine(), out strana3);
                } while (!checker1 || !checker2 || !checker3);
            

            
                if (strana1 + strana3 > strana2 && strana1 + strana2 > strana3 && strana2 + strana3 > strana1)
                {
                    Console.WriteLine("{0}, {1}, {2} jsou stranami trojuhleniku.", strana1, strana2, strana3);
                
                    if (strana1 == strana2 && strana2 == strana3)
                        Console.WriteLine("trojuhlenik je rovnostrany");
                
                    else if (strana1 == strana2 || strana2 == strana3)
                        Console.WriteLine("trojuhelnik je rovnorameny");
                    
                    double[] arrDouble = new double[3];
                    arrDouble[0] = strana1*strana1;
                    arrDouble[1] = strana2*strana2;
                    arrDouble[2] = strana3*strana3;
                    Array.Sort(arrDouble);
                    
                    if (arrDouble[0] + arrDouble[1] == arrDouble[2])
                        
                        Console.WriteLine("trojuhelnik je pravouhly");
                }
                else
                    Console.WriteLine("neni to trojuhlenik. program se zavira.");
            }
        }
    }
}