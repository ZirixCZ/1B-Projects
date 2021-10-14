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
            
            int sum = 0;
            if (number1 % 2 == 0)
                sum = sum + 1;
            
            if (number2 % 2 == 0)
                sum = sum + 1;
            
            if (number3 % 2 == 0)
                sum = sum + 1;
            
            if (number4 % 2 == 0)
                sum = sum + 1;
            
            Console.WriteLine($"pocet sudych cisel je {sum}");
        }
    }
}