var solution = new Solution();
//Console.WriteLine(solution.TotalFruit(new[] { 0, 0, 1, 1 }));
//Console.WriteLine(solution.TotalFruit(new[] { 0 }));
//Console.WriteLine(solution.TotalFruit(new[] { 1, 2, 3, 2, 2 }));
Console.WriteLine(solution.TotalFruit(new[] { 3, 3, 3, 1, 2, 1, 1, 2, 3, 3, 4 }));

// https://leetcode.com/problems/fruit-into-baskets
public class Solution
{
    public int TotalFruit(int[] fruits)
    {
        // 1 2 3 2 2
        // | | |
        //   | | | |

        var count = new Dictionary<int, int>();
        int res = 0, i = 0;
        for (int j = 0; j < fruits.Length; ++j)
        {
            if (count.ContainsKey(fruits[j]))
            {
                count[fruits[j]]++;
            }
            else
            {
                count.Add(fruits[j], 1);
            }
            while (count.Count > 2)
            {
                count[fruits[i]] = count[fruits[i]] - 1;
                if (count[fruits[i]] == 0)
                {
                    count.Remove(fruits[i]);
                }
                i++;
            }
            res = Math.Max(res, j - i + 1);
        }
        return res;
    }
}