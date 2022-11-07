var solution = new Solution();
Console.WriteLine(solution.HammingWeight(11));

Console.WriteLine(00000000000000000000000000001011);

//https://leetcode.com/problems/number-of-1-bits/
public class Solution {
    public int HammingWeight(uint n) {
        int ones = 0;
        while(n>0){
            ones = (ones + (int)(n & 1));
            n = n>>1;
        }
        return ones;
    }
}