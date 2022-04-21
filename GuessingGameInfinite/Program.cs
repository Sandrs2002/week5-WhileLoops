using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are playing guessing game with computer. Make your try.");
            int i = 0;
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 11);
            bool loopActive = true;


            while (loopActive)
            {
                Console.WriteLine($"Make your {i + 1} try");
                string Number = Console.ReadLine();
                i++;

                if(Number == $"{RandomNumber}")
                {
                    Console.WriteLine("Yay! You guessed computer's random number! Congratulations!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong umber. Try again.");
                }
            }
        }
    }
}
