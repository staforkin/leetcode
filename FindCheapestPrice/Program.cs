var solution = new Solution();
var flights = new int[][]{
    new int[]{0,1,100},
    new int[]{1,2,100},
    new int[]{2,0,100},
    new int[]{1,3,600},
    new int[]{2,3,200},
};

Console.WriteLine(solution.FindCheapestPrice(4, flights, 0, 3, 1));

// https://leetcode.com/problems/cheapest-flights-within-k-stops
public class Solution
{
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        int[] dist = new int[n];
        Array.Fill(dist, int.MaxValue);
        dist[src] = 0;
        for (int i = 0; i <= k; i++)
        {
            int[] temp = dist.ToArray();
            foreach (int[] flight in flights)
            {
                if (dist[flight[0]] != int.MaxValue)
                {
                    temp[flight[1]] = Math.Min(temp[flight[1]], dist[flight[0]] + flight[2]);
                }
            }
            dist = temp;
        }
        return dist[dst] == int.MaxValue ? -1 : dist[dst];
    }
    public int FindCheapestPrice4(int n, int[][] flights, int src, int dst, int k)
    {
        var map = new Dictionary<int, List<int[]>>();
        foreach (int[] i in flights)
        {
            if (!map.ContainsKey(i[0]))
            {
                map.Add(i[0], new List<int[]>());
            }
            map[i[0]].Add(new int[] { i[1], i[2] });
        }
        int step = 0;
        Queue<int[]> q = new Queue<int[]>();
        q.Enqueue(new int[] { src, 0 });
        int ans = int.MaxValue;
        while (q.Count > 0)
        {
            int size = q.Count;
            for (int i = 0; i < size; i++)
            {
                int[] curr = q.Dequeue();
                if (curr[0] == dst)
                    ans = Math.Min(ans, curr[1]);
                if (!map.ContainsKey(curr[0]))
                    continue;
                foreach (int[] f in map[curr[0]])
                {
                    if (curr[1] + f[1] > ans)      //Pruning
                        continue;
                    q.Enqueue(new int[] { f[0], curr[1] + f[1] });
                }
            }
            if (step++ > k)
                break;
        }
        return ans == int.MaxValue ? -1 : ans;
    }
    int ans_dfs;
    public int FindCheapestPrice3(int n, int[][] flights, int src, int dst, int k)
    {
        ans_dfs = int.MaxValue;
        var map = new Dictionary<int, List<int[]>>();
        foreach (int[] i in flights)
        {
            if (!map.ContainsKey(i[0]))
            {
                map.Add(i[0], new List<int[]>());
            }
            map[i[0]].Add(new int[] { i[1], i[2] });
        }
        dfs(map, src, dst, k + 1, 0);
        return ans_dfs == int.MaxValue ? -1 : ans_dfs;
    }

    public void dfs(Dictionary<int, List<int[]>> map, int src, int dst, int k, int cost)
    {
        if (k < 0)
        {
            return;
        }
        if (src == dst)
        {
            ans_dfs = cost;
            return;
        }
        if (!map.ContainsKey(src))
        {
            return;
        }
        foreach (int[] i in map[src])
        {
            if (cost + i[1] > ans_dfs)               //Pruning, check the sum of current price and next cost. If it's greater then the ans so far, continue
            { continue; }
            dfs(map, i[0], dst, k - 1, cost + i[1]);
        }
    }

    public int FindCheapestPrice2(int n, int[][] flights, int src, int dst, int k)
    {
        var prices = new Dictionary<int, Dictionary<int, int>>();
        foreach (int[] f in flights)
        {
            if (!prices.ContainsKey(f[0]))
            {
                prices.Add(f[0], new Dictionary<int, int>());
            }
            prices[f[0]].Add(f[1], f[2]);
        }
        //0: [1, 100]
        //1: [2, 100], [3, 600]
        //2: [0, 100], [3, 200]
        var pq = new PriorityQueue<int[], int>();
        pq.Enqueue(new int[] { 0, src, k + 1 }, 0);
        while (pq.Count > 0)
        {
            int[] top = pq.Dequeue();
            int price = top[0];
            int city = top[1];
            int stops = top[2];
            if (city == dst)
            {
                return price;
            }
            if (stops > 0)
            {
                var adj = prices.GetValueOrDefault(city, new Dictionary<int, int>());
                foreach (int a in adj.Keys)
                {
                    pq.Enqueue(new int[] { price + adj[a], a, stops - 1 }, price + adj[a]);
                }
            }
        }
        return -1;
    }
}