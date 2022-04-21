using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0;

            while(tries != 3)
            {
                Console.WriteLine("Enter your PIN");
                string userPIN = Console.ReadLine();

                if(userPIN == "1234")
                {
                    Console.WriteLine("Welcome");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid PIN. Try again.");
                    tries++;
                    Console.WriteLine($"You have tried {tries} times.");
                }
            }
            Console.WriteLine("Have a nice day");
        }
    }
}
