using System;

namespace FindMedianSortedArrays
{
    //https://leetcode.com/problems/median-of-two-sorted-arrays/
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = new []{1,3};
            var arr2 = new []{2};
            var solution = new Solution();
            Console.WriteLine(solution.FindMedianSortedArrays(arr1, arr2));
        }
    }

    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var lengthMerged = nums1.Length + nums2.Length;
            bool even = lengthMerged % 2 == 0;//чётный
            int m=0;
            int n=0;
            var mergedArray = new int[lengthMerged];
            for(int i=0;i < lengthMerged;i++){
                if(m>=nums1.Length){
                    mergedArray[i] = nums2[n];
                    n++;
                } else if(n>=nums2.Length){
                    mergedArray[i] = nums1[m];
                    m++;
                } else if(m<nums1.Length && n<nums2.Length && nums1[m]<nums2[n]){
                    mergedArray[i] = nums1[m];
                    m++;
                } else if(m<nums1.Length && n<nums2.Length && nums1[m]>=nums2[n]) {
                    mergedArray[i] = nums2[n];
                    n++;
                }
            }
            if(even){
                return (mergedArray[lengthMerged/2] + mergedArray[lengthMerged/2 - 1]) / 2f;
            }
            return mergedArray[lengthMerged/2];
        }
    }
}
