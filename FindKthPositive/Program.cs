var solution = new Solution();
Console.WriteLine(solution.FindKthPositive(new[] { 2, 3, 4, 7, 11 }, 5));
Console.WriteLine(solution.FindKthPositive(new[] { 1, 2, 3, 4 }, 2));

public class Solution
{
    public int FindKthPositive(int[] arr, int k)
    {
        // 1   56 8910
        //  234  7    11
        var set = arr.ToHashSet();
        int index = 0;
        int i = 1;
        while (index < k)
        {
            if (!set.Contains(i))
            {
                index++;
            }
            i++;
        }
        return i - 1;
    }

    public int FindKthPositive2(int[] arr, int k)
    {
        int missingCount = 0;
        List<int> list = new List<int>(arr);
        for (int i = 1; ; ++i)
        {
            if (list.Count > 0 && list[0] == i)
            {
                list.RemoveAt(0);
            }
            else
            {
                if (++missingCount == k)
                    return i;
            }
        }
        return 0;
    }
}