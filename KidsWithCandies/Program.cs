var solution = new Solution();
Console.WriteLine(string.Join(",", solution.KidsWithCandies(new[] { 2, 3, 5, 1, 3 }, 3)));

// https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        // 2 3 5 1 3
        // 5
        var res = new bool[candies.Length];
        var max = 0;

        foreach(var j in candies)
        {
            if(j > max)
            {
                max = j;
            }
        }
        int i = 0;
        foreach (var item in candies)
        {
            res[i] = item + extraCandies >= max;
            i++;
        }
        return res;
    }
}