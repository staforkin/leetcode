var solution = new Solution();
// Console.WriteLine(solution.NumDecodings("226"));
// Console.WriteLine(solution.NumDecodings("606"));
// Console.WriteLine(solution.NumDecodings("06"));
// Console.WriteLine(solution.NumDecodings("27"));
Console.WriteLine(solution.NumDecodings("10"));

//https://leetcode.com/problems/decode-ways/
public class Solution
{
    public int NumDecodings(string s)
    {
        if (s == null || s.Length == 0) {
            return 0;
        }
        int n = s.Length;
        int[] dp = new int[n+1];
        dp[0]=1;
        dp[1]=s[0]!='0'?1:0;
        for (int i = 2; i <= n; i++)
        {
            int first = int.Parse(s.Substring(i-1,1));
            int second = int.Parse(s.Substring(i-2,2));
            if(first>=1 && first<=9){
                dp[i]+=dp[i-1];
            }
            if(second>=10 && second<=26){
                dp[i]+=dp[i-2];
            }
        }
        return dp[n];
    }
}

/* TIMEOUT
public int NumDecodings(string s)
    {
        return s.Length == 0 ? 0 : helper(0, s);
    }

    private int helper(int p, string s)
    {
        int n = s.Length;
        if (p == n) return 1;
        if (s[p] == '0') return 0;
        int res = helper(p + 1, s);
        if (p < n - 1 && (s[p] == '1' || s[p] == '2' && s[p + 1] < '7'))
            res += helper(p + 2, s);
        return res;
    }
*/