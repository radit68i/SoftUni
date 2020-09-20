using System;

namespace _03._Elevator
{
    class _03_Elevator
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacityElevator = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)countOfPeople / capacityElevator);

            Console.WriteLine(courses);
        }
    }
}
