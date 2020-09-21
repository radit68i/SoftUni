using System;
using System.Threading.Channels;

namespace _05._Decrypting_Message
{
    class _05_Decrypting_Message
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            string result = "";
            for (int i = 0; i < n; i++)
            {
                char ch = (char)(char.Parse(Console.ReadLine()) + key);
                result += ch;
            }

            Console.WriteLine(result);
        }
    }
}
