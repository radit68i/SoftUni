using System;

namespace _06._Balanced_Brackets
{
    class _06_Balanced_Brackets
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());

            bool isBallanced = true;
            int countOpenBrackets = 0;
            int countCloseBrackets = 0;
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
               if (input.Trim() == "(")
                {
                    countOpenBrackets++;
                    
                }
               else if (input.Trim() == ")")
                {

                    countCloseBrackets++;
                   
                }
                if (countOpenBrackets - countCloseBrackets > 1)
                {
                    isBallanced = false;
                }
                if (countCloseBrackets > countOpenBrackets)
                {
                    isBallanced = false;
                }
            }
            if (isBallanced && countOpenBrackets == countCloseBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
