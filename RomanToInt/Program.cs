//https://leetcode.com/problems/roman-to-integer
var solution = new Solution();
Console.WriteLine(solution.RomanToInt("MCMXCIV"));

public class Solution {
    public int RomanToInt(string s) {
        //1994
        //            |
        //M C M X C I V
        int res = default;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            switch (s[i])
            {
                case 'I':
                    res += 1;
                    break;
                case 'V':
                    if (i > 0 && s[i - 1] == 'I')
                    {
                        res += 4;
                        i--;
                    }
                    else
                    {
                        res += 5;
                    }
                    break;
                case 'X':
                    if (i > 0 && s[i - 1] == 'I')
                    {
                        res += 9;
                        i--;
                    }
                    else
                    {
                        res += 10;
                    }
                    break;
                case 'L':
                    if (i > 0 && s[i - 1] == 'X')
                    {
                        res += 40;
                        i--;
                    }
                    else
                    {
                        res += 50;
                    }
                    break;
                case 'C':
                    if (i > 0 && s[i - 1] == 'X')
                    {
                        res += 90;
                        i--;
                    }
                    else
                    {
                        res += 100;
                    }
                    break;
                case 'D':
                    if (i > 0 && s[i - 1] == 'C')
                    {
                        res += 400;
                        i--;
                    }
                    else
                    {
                        res += 500;
                    }
                    break;
                case 'M':
                    if (i > 0 && s[i - 1] == 'C')
                    {
                        res += 900;
                        i--;
                    }
                    else
                    {
                        res += 1000;
                    }
                    break;
            }
        }

        return res;
    }
}