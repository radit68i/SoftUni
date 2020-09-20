using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = (char)int.Parse(Console.ReadLine());
            n += 'a';

            for (char i = 'a'; i < n; i++)
            {
                for (char j = 'a'; j < n; j++)
                {
                    for (char k = 'a'; k < n; k++)
                    {
                        string result = new string(new char[] { i, j, k });
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
