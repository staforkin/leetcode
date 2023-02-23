var soluition = new Solution();
Console.WriteLine(soluition.AddDigits(38));

// https://leetcode.com/problems/add-digits/
public class Solution
{
    public int AddDigits(int num)
    {
        var str = num.ToString();
        while (str.Length > 1)
        {
            str = str.Select(i => (int)(i - '0')).Sum().ToString();
        }
        return int.Parse(str);
    }

    public int AddDigits2(int num)
    {
        if (num == 0)
        {
            return 0;
        }

        return num % 9 == 0 ? 9 : num % 9;
    }
}