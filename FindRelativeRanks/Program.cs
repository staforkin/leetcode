var solution = new Solution();
foreach (var item in solution.FindRelativeRanks(new[] { 5, 4, 3, 2, 1 }))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/relative-ranks
public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        int[][] pair = new int[score.Length][];

        for (int i = 0; i < score.Length; i++)
        {
            pair[i] = new int[2];
            pair[i][0] = score[i];
            pair[i][1] = i;
        }

        Array.Sort(pair, null, Comparer<int[]>.Create((a, b) => b[0] - a[0]));

        String[] result = new String[score.Length];

        for (int i = 0; i < score.Length; i++)
        {
            if (i == 0)
            {
                result[pair[i][1]] = "Gold Medal";
            }
            else if (i == 1)
            {
                result[pair[i][1]] = "Silver Medal";
            }
            else if (i == 2)
            {
                result[pair[i][1]] = "Bronze Medal";
            }
            else
            {
                result[pair[i][1]] = (i + 1) + "";
            }
        }

        return result;
    }
}