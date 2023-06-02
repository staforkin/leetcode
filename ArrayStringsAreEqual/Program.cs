var solution = new Solution();
Console.WriteLine(solution.ArrayStringsAreEqual(new[] { "ab", "c" }, new[] { "a", "bce" }));

// https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent
public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var w1 = word1.SelectMany(i => i);
        var w2 = word2.SelectMany(i => i).GetEnumerator();
        foreach (var item in w1)
        {
            if (w2.MoveNext())
            {
                if (w2.Current == item)
                {

                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return !w2.MoveNext();
    }
}