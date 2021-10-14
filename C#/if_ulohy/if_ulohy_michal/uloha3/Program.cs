using System;

namespace iftstprj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napiste prvni cislo: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("Napiste druhe cislo: ");
            int.TryParse(Console.ReadLine(), out int number2);
            Console.Write("Napiste treti cislo: ");
            int.TryParse(Console.ReadLine(), out int number3);
            Console.Write("Napiste ctvrte cislo: ");
            int.TryParse(Console.ReadLine(), out int number4);
            Double sum = number1 + number2 + number3 + number4;
            Double prumer = sum / 4;
            Console.WriteLine("aritmeticky prumer je {0}", prumer);
        }
    }
}