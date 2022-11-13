using System.Collections.Generic;
var solution = new Solution();
Console.WriteLine(string.Join(",", solution.Intersect(new[] { 1, 2, 2, 1 }, new[] { 2, 2 })));

// https://leetcode.com/problems/intersection-of-two-arrays-ii
public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        if(nums1.Length>nums2.Length){
            return Intersect(nums2,nums1);
        }
        var res = new List<int>();
        var map = nums1.GroupBy(i=>i).ToDictionary(i=>i.Key, j=>j.Count());
        foreach (var i in nums2)
        {
            if(map.ContainsKey(i) && map[i]>0){
                res.Add(i);
                map[i]-=1;
            }
        }
        return res.ToArray();
    }
}