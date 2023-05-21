var solution = new Solution();
var grid = new int[][] { new[] { 0, 1 }, new[] { 1, 0 } };
Console.WriteLine(solution.ShortestBridge(grid));

// https://leetcode.com/problems/shortest-bridge
public class Solution
{
    public int ShortestBridge(int[][] grid)
    {
        // 0 1
        // 1 0

        if (grid.Length == 0)
        {
            return 0;
        }

        int n = grid.Length;
        int m = grid[0].Length;
        var queue = new Queue<int[]>();
        bool marked = false;

        // DFS to mark the all positions of first island to 2
        for (int i = 0; i < n; i++)
        {
            // WARNING: MUST use a boolean variable to check if we already marked the first island to 2. Otherwise,
            // we will only break from the inner loop, but will not jump out the outer loop
            if (marked)
            {
                break;
            }
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 1)
                {
                    // WARNING: MUST add all position of first island into queue as first level, they all can be the
                    // starting points of BFS level order traversal
                    dfs(grid, i, j, queue);
                    marked = true;
                    break;
                }
            }
        }

        int bridge = 0;
        while (queue.Any())
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                int[] curPoint = queue.Dequeue();
                int x = curPoint[0];
                int y = curPoint[1];

                // WARNING: CANNOT use if else statement, must use all if statement to check all four directions
                if (x > 0 && grid[x - 1][y] == 0)
                {
                    queue.Enqueue(new int[] { x - 1, y });
                    grid[x - 1][y] = 2;
                }
                if (x < n - 1 && grid[x + 1][y] == 0)
                {
                    queue.Enqueue(new int[] { x + 1, y });
                    grid[x + 1][y] = 2;
                }
                if (y > 0 && grid[x][y - 1] == 0)
                {
                    queue.Enqueue(new int[] { x, y - 1 });
                    grid[x][y - 1] = 2;
                }
                if (y < m - 1 && grid[x][y + 1] == 0)
                {
                    queue.Enqueue(new int[] { x, y + 1 });
                    grid[x][y + 1] = 2;
                }

                // once we find the second island, return current bridge value
                if (x > 0 && grid[x - 1][y] == 1 || x < n - 1 && grid[x + 1][y] == 1
                || y > 0 && grid[x][y - 1] == 1 || y < m - 1 && grid[x][y + 1] == 1)
                {
                    return bridge;
                }
            }
            bridge++;
        }
        return bridge;
    }

    public void dfs(int[][] grid, int i, int j, Queue<int[]> queue)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != 1)
        {
            return;
        }

        grid[i][j] = 2;
        queue.Enqueue(new int[] { i, j });
        dfs(grid, i - 1, j, queue);
        dfs(grid, i + 1, j, queue);
        dfs(grid, i, j - 1, queue);
        dfs(grid, i, j + 1, queue);
    }
}