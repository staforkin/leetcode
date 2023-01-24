var solution = new Solution();
var board = new int[][]{
    new int[]{-1,-1,-1,-1,-1,-1},
    new int[]{-1,-1,-1,-1,-1,-1},
    new int[]{-1,-1,-1,-1,-1,-1},
    new int[]{-1,35,-1,-1,13,-1},
    new int[]{-1,-1,-1,-1,-1,-1},
    new int[]{-1,15,-1,-1,-1,-1}
    };
Console.WriteLine(solution.SnakesAndLadders(board));

// https://leetcode.com/problems/snakes-and-ladders
public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        int n = board.Length;
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        bool[] visited = new bool[n * n + 1];
        for (int move = 0; queue.Any(); move++)
        {
            for (int size = queue.Count; size > 0; size--)
            {
                int num = queue.Dequeue();
                if (visited[num])
                {
                    continue;
                }
                visited[num] = true;
                if (num == n * n) //at the end
                {
                    //Console.WriteLine("Finish!");
                    return move;
                }
                for (int i = 1; i <= 6 && num + i <= n * n; i++)
                {
                    int next = num + i;
                    int value = getBoardValue(board, next);
                    if (value > 0) // is snake/ladder, jump to value
                    {
                        //Console.WriteLine($"Found ladder to {value}");
                        next = value;
                    }
                    if (!visited[next])// if nor visited yet, put to queue
                    {
                        //Console.WriteLine($"Put to queue {next}");
                        queue.Enqueue(next);
                    }
                }
            }
        }
        return -1;
    }

    private int getBoardValue(int[][] board, int num)
    {
        int n = board.Length;//columns count
        int r = (num - 1) / n;//number of row from bottom
        int x = n - 1 - r;//row in arrays terms
        int y = r % 2 == 0 ? num - 1 - r * n : n + r * n - num;//column in arrays terms
        return board[x][y];
    }
}