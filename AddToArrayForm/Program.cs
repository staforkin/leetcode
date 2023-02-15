var solution = new Solution();
Console.WriteLine(string.Join(",", solution.AddToArrayForm(new[] { 1, 2, 0, 0, }, 34)));

// https://leetcode.com/problems/add-to-array-form-of-integer
public class Solution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
        // 1 2 0 0
        // - - 3 4

        //     0 1 2 3
        // 0 1 2 3 4 5
        // - - 1 2 0 0 (4)
        // 9 1 3 7 3 4 (6)

        // 0 0 2 1
        // 4 3 - -
        // - - 0 0 2 1
        // 4 3 7 3 1 9

        var res = new List<int>();
        for (int i = num.Length - 1, carry = 0; i >= 0 || k > 0 || carry > 0; i--, k /= 10)
        {
            int d1 = i >= 0 ? num[i] : 0;
            int d2 = k % 10;
            int sum = d1 + d2 + carry;

            res.Add(sum % 10);
            carry = sum / 10;
        }
        res.Reverse();
        return res;
    }
}