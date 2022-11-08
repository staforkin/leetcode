var solution = new Solution();
var array = new[] { 0,0,1 };
solution.MoveZeroes(array);
Console.WriteLine(string.Join(',', array));

// https://leetcode.com/problems/move-zeroes
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // 1, 0, 2, 0, 3
        // 1, 2, 0, 3, 0
        // 1, 2, 3, 0, 0

        // 1 0 0 0 3
        // 
        int snowBallSize = 0; 
        for (int i=0;i<nums.Length;i++){
	        if (nums[i]==0){
                snowBallSize++; 
            }
            else if (snowBallSize > 0) {
	            int t = nums[i];
	            nums[i]=0;
	            nums[i-snowBallSize]=t;
            }
        }
    }
}