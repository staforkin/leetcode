using System;
using System.Text;

namespace AddBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddBinaryImpl("111", "11"));
        }

        public static string AddBinaryImpl(string a, string b)
        {
            //   1 1 1 = 4+2+1=7
            //     1 1 = 2+1=3
            // 1 0 1 0 = 8+2=10
            var sb = new StringBuilder();
            string first = a.Length >= b.Length ? a : b;
            string second = a.Length < b.Length ? a : b;
            int lengthDiff = first.Length - second.Length;
            int overflow = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                int j = i - lengthDiff;
                var t = j < 0 ? (char.GetNumericValue(first[i]) + overflow) : (char.GetNumericValue(first[i]) + char.GetNumericValue(second[j]) + overflow);
                overflow = t >= 2 ? 1 : 0;
                if(t>2 || t==1 ){
                    sb.Append('1');
                } else {
                    sb.Append('0');
                }
            }
            if(overflow > 0){
                sb.Append('1');
            }
            var arr = sb.ToString().ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
