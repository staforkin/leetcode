var solution = new Solution();
Console.WriteLine(solution.IsLongPressedName("alex", "aaleex"));

// https://leetcode.com/problems/long-pressed-name
public class Solution
{
    public bool IsLongPressedName(string name, string typed)
    {
        int diff = 0;
        for (int i = 0; i < typed.Length;)
        {
            //letters are equal -> go next
            if (diff <= i && i - diff < name.Length && typed[i] == name[i - diff])
            {
                i++;
            }
            // letters are not equal,  but we can link typed letter to name letter from the previous iteration
            else if (diff < i && i - diff - 1 < name.Length && typed[i] == name[i - diff - 1])
            {
                diff++;
            }
            else return false;
        }
        // check that at the end of name there's no odd symbols
        return typed.Length - diff == name.Length;
    }

}