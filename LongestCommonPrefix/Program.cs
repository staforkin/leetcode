using System;
using System.Linq;
using System.Text;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new[] { "ab", "a" };
            Console.Write(LongestCommonPrefix(strs));
        }

        private static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length < 1 || strs.Any(i=>i.Length<1))
            { return string.Empty; }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            var length = strs.Min(i => i.Length);
            int j = default;
            char c = strs[0][0];
            var prefix = new StringBuilder();

            while (strs.All(i => i[j] == c) && j < length)
            {
                prefix.Append(c);
                j++;
                if (j >= length)
                { break; }
                c = strs[0][j];
            }

            return prefix.ToString();
        }
    }
}
