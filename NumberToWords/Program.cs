using System;

namespace NumberToWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(NumberToWordsImpl(1234));
        }

        public static string NumberToWordsImpl(int num)
        {
            return num.ToString();
        }
    }
}
