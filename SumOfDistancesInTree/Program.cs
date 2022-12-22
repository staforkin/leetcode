var solution = new Solution();
var arr = new int[][]{new []{0,1},
                        new []{0,2},
                        new []{2,3},
                        new []{2,4},
                        new []{2,5}};

Console.WriteLine(string.Join(",", solution.SumOfDistancesInTree(6, arr)));

// https://leetcode.com/problems/sum-of-distances-in-tree
public class Solution
{
    // 0: 1,2
    // 1: 0
    // 2: 0, 3, 4, 5
    // 3: 2
    // 4: 2
    // 5: 2
    int[] res, count;
    List<HashSet<int>> tree;
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        tree = new List<HashSet<int>>();
        res = new int[n];
        count = new int[n];
        for (int i = 0; i < n; ++i)
            tree.Add(new HashSet<int>());
        foreach (var e in edges)
        {
            tree[e[0]].Add(e[1]);
            tree[e[1]].Add(e[0]);
        }
        dfs(0, -1);
        dfs2(0, -1);
        return res;
    }

    public void dfs(int root, int pre)
    {
        foreach (int i in tree[root])
        {
            if (i == pre) continue;
            dfs(i, root);
            count[root] += count[i];
            res[root] += res[i] + count[i];
        }
        count[root]++;
    }


    public void dfs2(int root, int pre)
    {
        foreach (int i in tree[root])
        {
            if (i == pre) continue;
            res[i] = res[root] - count[i] + count.Length - count[i];
            dfs2(i, root);
        }
    }

    public int[] SumOfDistancesInTree2(int n, int[][] edges)
    {
        // weights including visited
        // 0: 2
        // 1: 0
        // 2: 3 (4 with zero minus 1 since 0 was visited)
        // 3: 0
        // 4: 0
        // 5: 0
        var tree = new IList<int>[n];
        for (int i = 0; i < n; i++)
        {
            tree[i] = new List<int>();
        }

        foreach (var item in edges)
        {
            tree[item[0]].Add(item[1]);
            tree[item[1]].Add(item[0]);
        }

        var visited = new int[n];
        var weights = new int[n];
        for (int i = 0; i < n; i++)
        {
            visited[i] = 1;
            foreach (var item in tree[i])
            {
                if (visited[item] == 0)
                {
                    weights[i] += 1;
                }
            }
        }
        return weights;
    }
}