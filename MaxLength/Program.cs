using System;
using System.Collections.Generic;

namespace MaxLength
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { "aa", "bcefgyh" };
            Console.WriteLine(MaxLength(arr));
        }

        //https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
        public static int MaxLength(IList<string> arr)
        {
            List<string> res = new List<string>();
            res.Add("");
            foreach(var str in arr){
                if(!IsAllUnique(str.ToCharArray())) continue;
                List<string> resList = new List<string>();
                foreach (var candidate in res)
                {
                    var t = candidate+str;
                    if(IsAllUnique(t.ToCharArray())) resList.Add(t);
                }
                res.AddRange(resList);
            }
            int answer = 0;
            foreach(var s in res){
                answer = Math.Max(answer, s.Length);
            }
            return answer;
        }

        static bool IsAllUnique(char[] chars)
        {
            var frequency = new int[26];
            foreach (var c in chars)
            {
                ++frequency[c - 'a'];
                if (frequency[c - 'a'] > 1)
                { return false; }
            }
            return true;
        }
    }
}
