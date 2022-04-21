using System;

namespace SumOfRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            Random rnd = new Random();

            while(i != 10)
            {
                int newRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Step {i + 1}. Number {newRandomNumber}");
                sum = sum + newRandomNumber;
                i++;

            }
            Console.WriteLine($"Total of 10 numbers is {sum}");
        }
    }
}
