var solution = new Solution();
var trust = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 } };
Console.WriteLine(solution.FindJudge(3, trust));

//https://leetcode.com/problems/find-the-town-judge
public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        int[] count = new int[n + 1];
        foreach (int[] t in trust)
        {
            count[t[0]]--;
            count[t[1]]++;
        }
        for (int i = 1; i <= n; ++i)
        {
            if (count[i] == n - 1)
            {
                return i;
            }
        }
        return -1;
    }
}