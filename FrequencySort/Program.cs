using System.Text;

var solution = new Solution();
Console.WriteLine(solution.FrequencySort("tree111"));

// https://leetcode.com/problems/sort-characters-by-frequency/
public class Solution {
    public string FrequencySort(string s) {
        var dict = new Dictionary<char,int>();
        for (int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i])){
                dict[s[i]]++;
            } else {
                dict.Add(s[i],1);
            }
        }

        var sb = new StringBuilder();
        foreach (var item in dict.OrderByDescending(i=>i.Value))
        {
            sb.Append(item.Key,item.Value);
        }

        return sb.ToString();
    }
}