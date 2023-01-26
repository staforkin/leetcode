var solution = new Solution();
var flights = new int[][]{
    new int[]{0,1,100},
    new int[]{1,2,100},
    new int[]{2,0,100},
    new int[]{1,3,600},
    new int[]{2,3,200},
};

Console.WriteLine(solution.FindCheapestPrice(4, flights, 0, 3, 1));

// https://leetcode.com/problems/cheapest-flights-within-k-stops
public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {

    }
}