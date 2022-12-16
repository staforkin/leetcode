var solution = new Solution();
var arr = new int[][]{
    new []{1,2},
    new []{2,3},
    new []{2,4}
};
// https://leetcode.com/problems/find-center-of-star-graph/
public class Solution {
    public int FindCenter(int[][] edges) {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < edges.Length; i++)
        {
            for (int j = 0; j < edges[i].Length; j++)
            {
                if(dict.ContainsKey(edges[i][j])){
                    return edges[i][j];
                } else {
                    dict.Add(edges[i][j],1);
                }
            }
        }
        return 0;
    }
}