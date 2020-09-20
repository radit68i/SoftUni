using System;

namespace _07._Water_Overflow
{
    class _07_Water_Overflow
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            
           
            byte capacity = 255;
            short totalLiters = 0;

            for (byte i = 0; i < n; i++)
            {
                short inputLiters = short.Parse(Console.ReadLine());
                totalLiters += inputLiters;
                if (totalLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= inputLiters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
