using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = new char[3];

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = char.Parse(Console.ReadLine());
            }

            string result = string.Join("", charArr);
           
            Console.WriteLine(result);

        }
    }
}
