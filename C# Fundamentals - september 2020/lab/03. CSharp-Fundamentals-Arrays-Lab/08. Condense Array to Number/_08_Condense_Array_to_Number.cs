using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class _08_Condense_Array_to_Number
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (arr.Length > 1)
            {
                int[] condensedArr = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensedArr[i] = arr[i] + arr[i + 1];
                }
                arr = condensedArr;
            }
            Console.WriteLine(arr[0]);
        }
    }
}
