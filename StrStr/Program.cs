using System.Collections.Generic;

var solution = new Solution();
Console.WriteLine(solution.StrStr("hello","ll"));

//https://leetcode.com/problems/implement-strstr/
public class Solution {
    // 0 1 2 3 4
    // h e l l o = 5
    // l         = 1
    public int StrStr(string haystack, string needle) {
        if(needle.Length==0){
            return 0;
        }
        var set = new Dictionary<string,int>();
        for (int i = 0; i < haystack.Length-needle.Length+1; i++)
        {
            set.TryAdd(haystack.Substring(i,needle.Length),i);
        }
        if(set.ContainsKey(needle)){
            return set[needle];
        }
        return -1;
    }
}