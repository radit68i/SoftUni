using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            if (typeGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = group * 8.45;
                }
                else if(day == "Saturday")
                {
                    price = group * 9.80;
                }
                else // Sunday
                {
                    price = group * 10.46;
                }

                if (group >= 30)
                {
                    price -= price * 0.15;
                }
            }
            else if (typeGroup == "Business")
            {
                if (group >= 100)
                {
                    group -= 10;
                }

                if (day == "Friday")
                {
                    price = group * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = group * 15.6;
                }
                else // Sunday
                {
                    price = group * 16;
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = group * 15;
                }
                else if (day == "Saturday")
                {
                    price = group * 20;
                }
                else // Sunday
                {
                    price = group * 22.50;
                }

                if ((group >= 10) && (group <= 20))
                {
                    price -= price * 0.05;
                }

            }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
