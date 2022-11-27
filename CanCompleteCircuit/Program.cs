var solution = new Solution();
Console.WriteLine(solution.CanCompleteCircuit2(new[] { 0, 0, 0, 2 }, new[] { 0, 0, 1, 0 }));

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

    public int CanCompleteCircuit2(int[] gas, int[] cost)
    {
        int tank = 0;
        int start = 0;
        int total = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            if ((tank = tank + gas[i] - cost[i]) < 0)
            {
                start = i + 1; total += tank; tank = 0;
            }
        }
        return (total + tank < 0) ? -1 : start;
    }
}