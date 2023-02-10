var solution = new Solution();
var arr = new int[][] {
new int[] { 1, 0, 0, 1 },
new int[] { 0, 0, 0, 0 },
new int[] { 1, 0, 0, 0 },
new int[] { 0, 0, 0, 0 }
};
Console.WriteLine(solution.MaxDistance(arr));

// https://leetcode.com/problems/as-far-from-land-as-possible
public class Solution
{

    public int MaxDistance(int[][] grid)
    {
        var x = new int[] { -1, 0, 1, 0 };
        var y = new int[] { 0, 1, 0, -1 };
        // 1 0 0 1
        // 0 0 0 0
        // 1 0 0 0
        // 0 0 0 0

        var n = grid.Length;
        var m = grid[0].Length;

        var q = new Queue<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 1)
                {
                    q.Enqueue((i, j));
                }
            }
        }

        if (q.Count() == n * m)
        {
            return -1;
        }

        int dist = default;

        while (q.Any())
        {
            var size = q.Count;
            dist++;
            while (size-- > 0)
            {
                var (si, sj) = q.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    var newI = si + x[i];
                    var newJ = sj + y[i];
                    if (newI >= 0 && newI < n && newJ >= 0 && newJ < m && grid[newI][newJ] == 0)
                    {
                        q.Enqueue((newI, newJ));
                        grid[newI][newJ] = 1;
                    }
                }
            }
        }
        return dist - 1;
    }
}