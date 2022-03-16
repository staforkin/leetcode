var input = new char[][] {
    new char[9]{'8','3','.','.','7','.','.','.','.'},
    new char[9]{'6','.','.','1','9','5','.','.','.'},
    new char[9]{'.','9','8','.','.','.','.','6','.'},
    new char[9]{'8','.','.','.','6','.','.','.','3'},
    new char[9]{'4','.','.','8','.','3','.','.','1'},
    new char[9]{'7','.','.','.','2','.','.','.','6'},
    new char[9]{'.','6','.','.','.','.','2','8','.'},
    new char[9]{'.','.','.','4','1','9','.','.','5'},
    new char[9]{'.','.','.','.','8','.','.','7','9'},
    };
var solution = new Solution();
Console.WriteLine(solution.IsValidSudoku(input)+" expected False");

//https://leetcode.com/problems/valid-sudoku/
public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var horisontal = new HashSet<char>[9];
        var vertical = new HashSet<char>[9];
        var square = new HashSet<char>[9];
        for (int i = 0; i < 9; i++)
        {
            horisontal[i] = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                if (i == 0)
                {
                    vertical[j] = new HashSet<char>();
                }
                if (i % 3 == 0 && j % 3 == 0)
                {
                    square[(i/3)*3 + j/3] = new HashSet<char>();
                }
                if (board[i][j] != '.' && horisontal[i].Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    horisontal[i].Add(board[i][j]);
                }
                if (board[i][j] != '.' && vertical[j].Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    vertical[j].Add(board[i][j]);
                }
                if (board[i][j] != '.' && square[(i/3)*3 + j/3].Contains(board[i][j]))
                {
                    return false;
                }
                else
                {
                    square[(i/3)*3 + j/3].Add(board[i][j]);
                }
            }
        }
        return true;
    }
}