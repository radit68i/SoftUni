using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int yearsInOneCentury = 100;
            double daysInOneYear = 365.2422;
            int hoursInOneDay = 24;
            int minutesInOnHour = 60;

            int years = centuries * yearsInOneCentury;
            int days = (int)(years * daysInOneYear);
            int hours = days * hoursInOneDay;
            int minutes = hours * minutesInOnHour;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
