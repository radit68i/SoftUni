using System;

namespace _08._Beer_Kegs
{
    class _08_Beer_Kegs
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            string biggestKeg = "";
            double biggestVolume = 0;
            for (byte i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestKeg = model;
                    biggestVolume = volume;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
