var solution = new Solution();

var board = new char[][]{
new []{'a','b','c','e'},
new []{'s','f','c','s'},
new []{'a','d','e','e'}};

Console.WriteLine(solution.Exist(board, "abcced"));

//https://leetcode.com/problems/word-search
public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        char[] w = word.ToArray();
        for (int y = 0; y < board.Length; y++)
        {
            for (int x = 0; x < board[y].Length; x++)
            {
                if (exist(board, y, x, w, 0)) return true;
            }
        }
        return false;
    }

    private bool exist(char[][] board, int y, int x, char[] word, int i)
    {
        if (i == word.Length) return true;
        if (y < 0 || x < 0 || y == board.Length || x == board[y].Length) return false;
        if (board[y][x] != word[i]) return false;
        board[y][x] = '*';
        bool ex = exist(board, y, x + 1, word, i + 1)
            || exist(board, y, x - 1, word, i + 1)
            || exist(board, y + 1, x, word, i + 1)
            || exist(board, y - 1, x, word, i + 1);
        board[y][x] = word[i];
        return ex;
    }
}