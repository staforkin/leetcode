var solution = new Solution();
Console.WriteLine(string.Join(" ", solution.CalcEquation(new[] { new[] { "a", "b" }, new[] { "b", "c" } }, new[] { 2.0, 3.0 }, new[]{
    new []{"a","c"},
    new []{"b","a"},
    new []{"a","e"},
    new []{"a","a"},
    new []{"x","x"}
})));

// https://leetcode.com/problems/evaluate-division
public class Solution
{
    public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
    {
        var graph = buildGraph(equations, values);
        double[] result = new double[queries.Count];

        for (int i = 0; i < queries.Count; i++)
        {
            result[i] = getPathWeight(queries[i][0], queries[i][1], new HashSet<string>(), graph);
        }

        return result;
    }

    private double getPathWeight(string start, string end, HashSet<string> visited, Dictionary<string, Dictionary<string, double>> graph)
    {

        /* Rejection case. */
        if (!graph.ContainsKey(start))
        {
            return -1.0;
        }

        /* Accepting case. */
        if (graph[start].ContainsKey(end))
        {
            return graph[start][end];
        }

        visited.Add(start);
        foreach (var neighbour in graph[start])
        {
            if (!visited.Contains(neighbour.Key))
            {
                double productWeight = getPathWeight(neighbour.Key, end, visited, graph);
                if (productWeight != -1.0)
                {
                    return neighbour.Value * productWeight;
                }
            }
        }

        return -1.0;
    }

    private Dictionary<string, Dictionary<string, double>> buildGraph(IList<IList<string>> equations, double[] values)
    {
        var graph = new Dictionary<string, Dictionary<string, double>>();
        String u, v;

        for (int i = 0; i < equations.Count; i++)
        {
            u = equations[i][0];
            v = equations[i][1];
            graph.TryAdd(u, new Dictionary<string, double>());
            graph[u].Add(v, values[i]);
            graph.TryAdd(v, new Dictionary<string, double>());
            graph[v].Add(u, 1 / values[i]);
        }

        return graph;
    }
}