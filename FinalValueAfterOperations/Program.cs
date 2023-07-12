var solution = new Solution();
Console.WriteLine(solution.FinalValueAfterOperations(new[] { "--X", "X++", "X++" }));

// https://leetcode.com/problems/final-value-of-variable-after-performing-operations
public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int cntPlus = 0;
        int cntMinus = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i][1] == '+')
            {
                cntPlus++;
            }
            else
            {
                cntMinus++;
            }
        }
        return cntPlus - cntMinus;
    }
}