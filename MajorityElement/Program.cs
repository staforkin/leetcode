var solution = new Solution();
Console.WriteLine(solution.MajorityElement(new[] { 1 }));

//https://leetcode.com/problems/majority-element
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var limit = nums.Length / 2;
        var dictionary = new Dictionary<int,int>();
        foreach (var item in nums)
        {
            if(dictionary.TryGetValue(item, out int val)){
                if(val+1>limit)
                    return item;
                dictionary[item] = val+1;
            } else {
                dictionary.Add(item, 1);
            }
        }
        return dictionary.FirstOrDefault().Key;
    }
}