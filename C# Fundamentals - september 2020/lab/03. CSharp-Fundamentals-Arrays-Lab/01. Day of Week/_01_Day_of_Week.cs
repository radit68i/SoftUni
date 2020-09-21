using System;

namespace _01._Day_of_Week
{
    class _01_Day_of_Week
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string result = "Invalid day!";

            if (n <= 7 && n >= 1)
            {
                result = daysOfWeek[n - 1];
            }

            Console.WriteLine(result);
        }
    }
}
