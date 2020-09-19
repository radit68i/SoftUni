using System;
using System.Linq;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNum = Console.ReadLine();

            int[] digits = strNum.ToArray().Select(x => int.Parse(x.ToString())).ToArray();
       
            int sumFact = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                int currDidit = digits[i];
          
                int fact = 1;
                for (int j = 1; j <= currDidit; j++)
                {
                    fact *= j;
                }
                sumFact += fact;
            }

            if (sumFact == int.Parse(strNum))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
