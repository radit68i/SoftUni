using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class _07_Equal_Arrays
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string result = "";
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    result = $"Arrays are not identical. Found difference at {i} index";
                    break;
                }
            }

            if (result == "")
            {
                result = $"Arrays are identical. Sum: {arr1.Sum()}";
            }

            Console.WriteLine(result);
        }
    }
}
