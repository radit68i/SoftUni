using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            for (int i = 1; i <= 4; i++)
            {
                string password = string.Join("", Console.ReadLine().Reverse().ToArray());
                if (password == userName)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    if (i != 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"User {userName} blocked!");
                    }
                }
            }

        }
    }
}
