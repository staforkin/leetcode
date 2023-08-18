var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SelfDividingNumbers(1, 22)));

// https://leetcode.com/problems/self-dividing-numbers/
public class Solution
{
    public IList<int> SelfDividingNumbers(int left, int right)
    {
        var res = new List<int>();
        for (int i = left, n = 0; i <= right; i++)
        {
            for (n = i; n > 0; n /= 10)
            {
                if (n % 10 == 0 || i % (n % 10) != 0)
                {
                    break;
                }
            }
            if (n == 0)
            {
                res.Add(i);
            }
        }
        return res;
    }
}