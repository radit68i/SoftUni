using System;

namespace _10._Poke_Mon
{
    class _10_Poke_Mon
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            double fiftyPercentPower = pokePower / 2.0;
            int target = 0;
            while (pokePower >= distance)
            {
                pokePower -= distance;
                target++;
                if (pokePower == fiftyPercentPower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                    
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(target);
        }
    }
}
