using System;

namespace GuessingGameThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"You are playing guessing game with computer.");
            int i = 0;
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1, 11);


            while(i != 3)
            {
                Console.WriteLine($"Make your {i + 1} try.");
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
            while(i == 3)
            {
                string YourNumber = Console.ReadLine();

                if (YourNumber != $"{RandomNumber}")
                {
                    Console.WriteLine($"You have no attempts left. Random number was {RandomNumber}");
                    break;
                }
            }
        }
    }
}
