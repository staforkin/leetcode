var solution = new Solution();
foreach (var item in solution.Partition("aab"))
{
    Console.WriteLine(string.Join(",", item));
}

// https://leetcode.com/problems/palindrome-partitioning
public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return new List<IList<string>>();
        }
        var result = new List<List<string>>();
        helper(s, new List<string>(),result);
        return result.ToArray();
    }

    public void helper(string s, List<string> step, List<List<string>> result)
    {
        if (string.IsNullOrEmpty(s))
        {
            result.Add(new List<string>(step));
            return;
        }
        for (int i = 1; i <= s.Length; i++)
        {
            var temp = s.Substring(0, i);
            if (!isPalindrome(temp)) continue;

            step.Add(temp);
            helper(s.Substring(i), step, result);
            step.RemoveAt(step.Count - 1);
        }
        return;
    }

    public bool isPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left <= right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}