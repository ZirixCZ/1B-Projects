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
            int[] arr = new int[4];
            arr[0] = number1;
            arr[1] = number2;
            arr[2] = number3;
            arr[3] = number4;
            bool checker = false;
            int a = arr[0];
            int b = arr[1];
            int c = arr[2];
            int d = arr[3];
            do
            {
                if (arr[0] > arr[1])
                {
                    int holderMax = arr[0];
                    int holderMin = arr[1];
                    arr[1] = holderMax;
                    arr[0] = holderMin;
                }

                if (arr[1] > arr[2])
                {
                    int holderMax = arr[1];
                    int holderMin = arr[2];
                    arr[2] = holderMax;
                    arr[1] = holderMin;
                }

                if (arr[2] > arr[3])
                {
                    int holderMax = arr[2];
                    int holderMin = arr[3];
                    arr[3] = holderMax;
                    arr[2] = holderMin;
                }

                a = arr[0];
                b = arr[1];
                c = arr[2];
                d = arr[3];
                if (a < b && a < c && a < d && b > a && b < c && b < d && c > a && c > b && c < d && d > a && d > b &&
                    d > c)
                    checker = true;
            } while (!checker);

                
                
            
            
            Console.WriteLine($"serazeno od nejmensiho: {arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}");

            
            
            
            
            
            
            
            
            
            

            // int min = number1;
            // int max = number1;
            // string holderMax = "";
            // string holderMin = "";
            // string holder = "";
            //
            // if (min >= number2)
            //     min = number2;
            // else if (min >= number3)
            //     min = number3;
            // else if (min >= number4)
            //     min = number4;
            //
            // if (max <= number2)
            //     max = number2;
            // else if (max <= number3)
            //     max = number3;
            // else if (max <= number4)
            //     max = number4;
            //
            // if (number1 == min)
            //     holderMin = number1 + holderMin;
            // else if (number1 == max)
            //     holderMax = holderMax + number1;
            // if (number2 == min)
            //     holderMin = holderMin + number2;
            // else if (number2 == max)
            //     holderMax = holderMax + number2;
            // if (number3 == min)
            //     holderMin = holderMin + number3;
            // else if (number3 == max)
            //     holderMax = holderMax + number3;
            // if (number4 == min)
            //     holderMin = holderMin + number4;
            // else if (number4 == max)
            //     holderMax = holderMax + number4;
            //
            //
            // if (number1 == min || number1 == max && number2 == min || number2 == max)
            // {
            //     if (number3 >= number4)
            //         {
            //             holder = holderMin + number4 + number3 + holderMax;
            //         }
            //         else if (number3 <= number4)
            //             holder = holderMin + number3 + number4 + holderMax;
            // }
            //
            // if (number2 == min || number2 == max && number3 == min || number3 == max)
            // {
            //     if (number1 >= number4)
            //         {
            //             holder = holderMin + number4 + number1 + holderMax;
            //         }
            //         else if (number3 <= number4)
            //             holder = holderMin + number1 + number4 + holderMax;
            // }
            //
            // if (number3 == min || number3 == max && number4 == min || number4 == max)
            // {
            //     if (number1 >= number2)
            //         {
            //             holder = holderMin + number2 + number1 + holderMax;
            //         }
            //         else if (number1 <= number2)
            //             holder = holderMin + number1 + number2 + holderMax;
            // }
            // if (number4 == min || number4 == max && number1 == min || number1 == max)
            // {
            //     if (number1 >= number4)
            //         {
            //             holder = holderMin + number1 + number4 + holderMax;
            //         }
            //         else if (number1 <= number4)
            //             holder = holderMin + number4 + number1 + holderMax;
            // }

            // Console.WriteLine("cisla serazena sestupne: " + holder);





            // if (x == number1 && e == number2)
            //     Console.WriteLine("{0}, {1}, {2}",e, number3, x);
            // if (x == number2 && e == number3)
            //     Console.WriteLine("{0}, {1}, {2}",e, number1, x);
            // if (x == number3 && e == number1)
            //     Console.WriteLine("{0}, {1}, {2}",e, number2, x);
            //
            // if (x == number2 && e == number1)
            //     Console.WriteLine("{0}, {1}, {2}",e, number3, x);
            // if (x == number3 && e == number2)
            //     Console.WriteLine("{0}, {1}, {2}",e, number1, x);
            // if (x == number1 && e == number3)
            //     Console.WriteLine("{0}, {1}, {2}",e, number2, x);
            //
            // Console.WriteLine("nejmensi cislo je {0}, nejvetsi je {1}", e, x);
        }
    }
}