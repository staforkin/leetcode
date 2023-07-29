var solution = new Solution();
Console.WriteLine(string.Join(",", solution.SortArrayByParity(new[] { 3, 1, 2, 4 })));

// https://leetcode.com/problems/sort-array-by-parity
public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var oddIndecesVisited = new int[nums.Length];
        var res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i]%2==0){
                oddIndecesVisited[i]=1;
                res.Add(nums[i]);
            };
        }
        for (int i = 0; i < oddIndecesVisited.Length; i++)
        {
            if(oddIndecesVisited[i]==0){
                res.Add(nums[i]);
            }
        }

        return res.ToArray();
    }
}