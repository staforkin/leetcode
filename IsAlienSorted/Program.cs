using System;
using System.Collections.Generic;
using System.Linq;

namespace IsAlienSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAlienSortedImpl(new string[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz"));
        }
        public static bool IsAlienSortedImpl(string[] words, string order)
        {
            int[] orderMap = new int[26];
            for (int i = 0; i < order.Length; i++)
            {
                orderMap[order[i] - 'a'] = i;
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j >= words[i + 1].Length)
                    {
                        return false;
                    }
                    if (words[i][j] != words[i + 1][j])
                    {
                        int currentWordChar = words[i][j] - 'a';
                        int nextWordChar = words[i + 1][j] - 'a';
                        if (orderMap[currentWordChar] > orderMap[nextWordChar])
                        {
                            return false;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return true;
        }
    }
}
