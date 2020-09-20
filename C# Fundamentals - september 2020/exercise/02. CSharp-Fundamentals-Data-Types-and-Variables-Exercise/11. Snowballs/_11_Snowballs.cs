using System;
using System.Numerics;

namespace _11._Snowballs
{
    class _11_Snowballs
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            BigInteger maxSnowball = 0;
            string result = "";
            for (byte i = 0; i < n; i++)
            {
                ushort snowballSnow = ushort.Parse(Console.ReadLine()) ;
                ushort snowballTime = ushort.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > maxSnowball)
                {
                    maxSnowball = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }
            Console.WriteLine(result);
        }
    }
}
