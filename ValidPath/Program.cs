var solution = new Solution();
var n = 3;
var arr = new int[][]{new []{0,1},new []{1,2},new []{2,3}, new []{3,0}};
Console.WriteLine(solution.ValidPath(n,arr,1,23));

// https://leetcode.com/problems/find-if-path-exists-in-graph
public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        // 0 -> 1 -> 2 -> 3 -> 0
    }
}