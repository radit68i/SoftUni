using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Join("", Console.ReadLine().Reverse().ToArray());
            Console.WriteLine(input);
        }
    }
}
