using System;

namespace _02._English_Name_of_the_Last_Digit
{
    class Program
    {
        static string LastDigit(int num)
        {
            int lastDigit = num % 10;
            string result = "";
            switch (lastDigit)
            {
                case 0:
                    result = "zero";
                        break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(LastDigit(num));
        }
    }
}
