using System;

namespace plus_one
{
    class PlusOneClass
    {
        static void Main(string[] args)
        {
            var digits = new[] { 9,9,9 };
            var plusOne = PlusOne(digits);
            foreach (var item in plusOne)
            {
                Console.Write(item);
            }
        }
        public static int[] PlusOne(int[] digits)
        {
            var overflowFlag = false;
            var i = digits.Length - 1;
            do
            {
                if(i<0){
                    var newDigits = new int[digits.Length+1];
                    newDigits[0]=0;
                    Array.Copy(digits,0, newDigits, 1, digits.Length);
                    digits = newDigits;
                    i=0;
                }
                var newNumber = digits[i] + 1;
                if (newNumber > 9)
                {
                    newNumber = 0;
                    overflowFlag = true;
                }
                else { overflowFlag = false; }
                digits[i] = newNumber;
                i--;
            } while (overflowFlag);
            return digits;
        }
    }
}
