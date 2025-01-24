using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if a username was provided as an argument
            if (args.Length > 0)
            {
                string username = args[0];
                Console.WriteLine($"The entered username is: {username}");
            }
            else
            {
                Console.WriteLine("No username provided.");
            }
        }
    }
}
