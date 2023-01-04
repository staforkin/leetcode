var solution = new Solution();
Console.WriteLine(solution.MinDeletionSize(new[] { "abc", "bce", "cae" }));

// https://leetcode.com/problems/delete-columns-to-make-sorted
public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        // String length.
        int K = strs[0].Length;

        // Variable to store the count of columns to be deleted.
        int answer = 0;

        // Iterate over each index in the string.
        for (int col = 0; col < K; col++)
        {

            // Iterate over the strings.
            for (int row = 1; row < strs.Length; row++)
            {
                // Characters should be in increasing order,
                // If not, increment the counter.
                if (strs[row][col] < strs[row - 1][col])
                {
                    answer++;
                    break;
                }
            }
        }
        return answer;
    }
}