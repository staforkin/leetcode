using System;

namespace Solution
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(DivideImpl(-2147483648, -1));
        }

        public static int DivideImpl(int dividend, int divisor)
        {
            if (dividend == Int32.MinValue && divisor == -1)
            {
                return Int32.MaxValue;
            }

            int negatives = 2;
            if (dividend > 0)
            {
                negatives--;
                dividend = -dividend;
            }
            if (divisor > 0)
            {
                negatives--;
                divisor = -divisor;
            }

            int quotient = 0;
            while (dividend - divisor <= 0)
            {
                quotient--;
                dividend -= divisor;
            }
            if (negatives != 1)
            {
                quotient = -quotient;
            }
            return quotient;
        }
    }
}
