var solution = new Solution();
Console.WriteLine(solution.CanCompleteCircuit(new[] { 0,0,0,2 }, new[] { 0,0,1,0 }));

// https://leetcode.com/problems/gas-station/
public class Solution
{
    // 0 1 2 3 4

    // 1 2 3 4 5
    // 3 4 5 1 2
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int res = -1;
        int n = gas.Length;
        for (int i = 0; i < n; i++)
        {
            if (cost[i] > gas[i] || gas[i] == 0) // no point to start with zero fuel or fuel < cost
            {
                continue;
            }
            if (CanComplete(gas, cost, i))
            {
                return i;
            }
        }
        return res;
    }

    private bool CanComplete(int[] gas, int[] cost, int startFrom)
    {
        int gasLeft = 0;
        int n = gas.Length;
        for (int i = 0; i < n; i++)
        {
            int index = (i + startFrom) % n;
            gasLeft = gasLeft + gas[index] - cost[index];
            if (gasLeft < 0)
            { return false; }
        }
        return true;
    }
}