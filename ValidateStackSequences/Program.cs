var solution = new Solution();
//Console.WriteLine(solution.ValidateStackSequences(new[] { 1, 2, 3, 4, 5 }, new[] { 4, 5, 3, 2, 1 }));
Console.WriteLine(solution.ValidateStackSequences(new[] { 2, 1, 0 }, new[] { 1, 2, 0 }));

// https://leetcode.com/problems/validate-stack-sequences/
public class Solution
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        var st = new Stack<int>();

        int j = 0;

        foreach (int val in pushed)
        {
            st.Push(val);
            while (st.Any() && st.Peek() == popped[j])
            {
                st.Pop();
                j++;
            }
        }
        return !st.Any();
    }
}