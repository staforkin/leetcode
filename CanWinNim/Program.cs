var solution = new Solution();
Console.WriteLine(solution.CanWinNim(2));
Console.WriteLine(solution.CanWinNim(4));
Console.WriteLine(solution.CanWinNim(11));
Console.WriteLine(solution.CanWinNim(12));

// https://leetcode.com/problems/nim-game
public class Solution
{
    public bool CanWinNim(int n)
    {
        // 1: true
        // 2: true
        // 3: true
        // 4: false
        // 5: 1 + 4 true
        // 6: 2 + 4 true 
        // 7: 3 + 4 true
        // 8: false 1+7, 2+6, 3+5
        // 9: true
        // 10: true
        // 11: true
        // 12: false
        return n % 4 != 0;
    }
}