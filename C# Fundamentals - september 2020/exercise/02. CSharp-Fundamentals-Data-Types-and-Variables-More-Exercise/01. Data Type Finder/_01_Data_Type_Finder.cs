using System;

namespace _01._Data_Type_Finder
{
    class _01_Data_Type_Finder
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string dataType = "string";
                int intDummy;
                double doubleDummy;
                char charDummy;
                bool boolDummy;
                if (int.TryParse(input, out intDummy))
                {
                    dataType = "integer";
                    
                }
                else if (double.TryParse(input, out doubleDummy))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out charDummy))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input, out boolDummy))
                {
                    dataType = "boolean";
                }
                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
            }
        }
    }
}
