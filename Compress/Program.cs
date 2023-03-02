var solution = new Solution();
Console.WriteLine(solution.Compress(new[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' }));

// https://leetcode.com/problems/string-compression
public class Solution
{
    public int Compress(char[] chars)
    {
        int indexAns = 0, index = 0;
        while (index < chars.Length)
        {
            char currentChar = chars[index];
            int count = 0;
            while (index < chars.Length && chars[index] == currentChar)
            {
                index++;
                count++;
            }
            chars[indexAns++] = currentChar;
            if (count != 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[indexAns++] = c;
                }
            }
        }
        return indexAns;
    }
}