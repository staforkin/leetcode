using System.Text;

var solution = new Solution();
foreach (var item in solution.RestoreIpAddresses("25525511135"))
{
    Console.WriteLine(item);
}

// https://leetcode.com/problems/restore-ip-addresses
public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        // 255 255 111 35
        // 255 255 11 135
        List<string> list = new List<string>();
        backtrack(s, list, new StringBuilder(), 0, 0);
        return list;
    }

    private void backtrack(string s, List<string> list, StringBuilder sb, int index, int level)
    {
        if (index > s.Length || level > 4)
        {
            return;
        }
        else if (index == s.Length && level == 4)
        {
            list.Add(sb.ToString());
            return;
        }
        for (int i = 1; i <= 3; i++)
        {
            if (index + i > s.Length) break;
            int num = int.Parse(s.Substring(index, i));
            //Checking if num is 0~9 or 10~99 or 100 ~ 255 because leading 0s is invalid.
            if (i == 1 || i == 2 && num >= 10 && num <= 99 || i == 3 && num >= 100 && num <= 255)
            {
                sb.Append(num);
                if (level < 3)
                {
                    sb.Append(".");
                }
                backtrack(s, list, sb, index + i, level + 1);
                if (level < 3)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
                sb.Remove(sb.Length - i, i);
            }
        }
    }
}