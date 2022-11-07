var solution = new Solution();
Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));

//https://leetcode.com/problems/valid-anagram
public class Solution {
    public bool IsAnagram(string s, string t) {
        var sArr = s.ToCharArray();
        var tArr = t.ToCharArray();
        Array.Sort(sArr);
        Array.Sort(tArr);
        return Enumerable.SequenceEqual(sArr, tArr);
    }
}