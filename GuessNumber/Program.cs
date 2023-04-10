// https://leetcode.com/problems/guess-number-higher-or-lower
public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        int low = 1, high = n;
        int result = low + (high - low) / 2;
        int guesss = 0;
        while ((guesss = (guess(result))) != 0)
        {
            if (guesss > 0)
            {
                low = result + 1;
            }
            else
            {
                high = result - 1;
            }
            result = low + (high - low) / 2;
        }
        return result;
    }
}

public class GuessGame
{
    protected virtual int guess(int n)
    {
        return n;
    }
}