using System;

namespace Uppgift4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer = 1;

            while (nummer < 101)
            {
                if (nummer % 3 == 0 && nummer % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    nummer++;
                }
                else if (nummer % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    nummer++;
                }
                else if (nummer % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    nummer++;
                }
                else
                {
                    Console.WriteLine(nummer);
                    nummer++;
                }
            }
        }
    }
}