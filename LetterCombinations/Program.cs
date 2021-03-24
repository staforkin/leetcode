using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterCombinations
{
    class Program
    {
        static readonly Dictionary<int, char[]> map = new Dictionary<int, char[]>(){
            {2, new[]{'a','b','c'}},
            {3, new[]{'d','e','f'}},
            {4, new[]{'g','h','i'}},
            {5, new[]{'j','k','l'}},
            {6, new[]{'m','n','o'}},
            {7, new[]{'p','q','r', 's'}},
            {8, new[]{'t','u','v'}},
            {9, new[]{'w','x','y', 'z'}},
        };
        static void Main(string[] args)
        {
            var lists = LetterCombinations("");
            foreach (var item in lists)
            {
                Console.WriteLine(string.Join(null, item));
            }
        }

        private static IList<string> LetterCombinations(string digits)
        {
            if(string.IsNullOrWhiteSpace(digits)){
                return new string[0];
            }
            var ints = digits.ToCharArray()
                .Select(i=>Int32.Parse(i.ToString()))
                .ToArray();
            var length = ints.Length;
            var maps = new List<char[]>();
            foreach (var item in ints)
            {
                maps.Add(map[item]);
            }
            var tmp = maps[0].Select(i=>i.ToString()).ToArray();
            for (int i = 1; i < length; i++)
            {
                tmp = MultiplyArrays(tmp,maps[i].Select(i=>i.ToString()).ToArray());
            }
            return tmp;
        }

        private static string[] MultiplyArrays(string[] s1, string[] s2)
        {
            var result = new string[s1.Length* s2.Length];
            int k=0;
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s2.Length; j++)
                {
                    result[k]=s1[i]+s2[j];
                    k++;
                }
            }
            return result;
        }
    }
}
