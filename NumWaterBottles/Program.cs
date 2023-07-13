var solution = new Solution();
Console.WriteLine(solution.NumWaterBottles(9, 3));

// https://leetcode.com/problems/water-bottles
public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        int ans = numBottles;
        while (numBottles >= numExchange)
        {
            int remains = numBottles % numExchange;
            numBottles /= numExchange;
            ans += numBottles;
            numBottles += remains;
        }
        return ans;
    }
}