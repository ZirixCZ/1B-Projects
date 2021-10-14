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
            
            int i = number1;
            int e = 0;
            int sum = 0;
            int count = 0;
            if (i <= number2)
                i = number2;
            
            if (i <= number3)
                i = number3;
            
            if (i <= number4)
                i = number4;
            
            if (i == number1)
                sum = sum + 1;
            
            if (i == number2)
                sum = sum + 1;
            
            if (i == number3)
                sum = sum + 1;
            
            if (i == number4)
                sum = sum + 1;


            Console.WriteLine($"nejvetsi cislo je {i}, objevilo se {sum}");
        }
    }
}