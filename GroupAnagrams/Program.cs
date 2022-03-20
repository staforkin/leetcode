var solution = new Solution();
foreach (var item in solution.GroupAnagrams(new[] { "eat", "tea", "tan", "ate", "nat", "bat" }))
{
    Console.WriteLine(string.Join(",", item));
}

//https://leetcode.com/problems/group-anagrams/submissions/
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return new List<IList<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var ca = new char[26];
            foreach (var s in str)
            {
                ca[s-'a']++;
            }
            var keyStr = new string(ca);
            if(!dict.ContainsKey(keyStr)){
                dict.Add(keyStr, new List<string>());
            }
            dict[keyStr].Add(str);
        }
        return dict.Select(i=>i.Value).ToArray();
    }
}