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

/* int[] alphabet = new int[26];
        for (int i = 0; i < s.length(); i++) alphabet[s.charAt(i) - 'a']++;
        for (int i = 0; i < t.length(); i++) alphabet[t.charAt(i) - 'a']--;
        for (int i : alphabet) if (i != 0) return false;
        return true; */