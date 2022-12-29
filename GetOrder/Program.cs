var solution = new Solution();
var tasks = new int[][]{
    new int[]{1,2},
    new int[]{2,4},
    new int[]{3,2},
    new int[]{4,1}
};
Console.WriteLine(string.Join(",", solution.GetOrder(tasks)));

// https://leetcode.com/problems/single-threaded-cpu
public class Solution
{
    public int[] GetOrder(int[][] tasks)
    {
        int n = tasks.Length;
        int[] ans = new int[n];
        int[][] extTasks = new int[n][];
        for (int i = 0; i < n; i++)
        {
            extTasks[i] = new int[3];
            extTasks[i][0] = i; // task's index
            extTasks[i][1] = tasks[i][0]; // task's enqueue time
            extTasks[i][2] = tasks[i][1]; // task's processing time
        }
        Array.Sort(extTasks, Comparer<int[]>.Create((a, b) => a[1].CompareTo(b[1]))); // sort by enqueue time
        PriorityQueue<int[], int[]> pq = new PriorityQueue<int[], int[]>(Comparer<int[]>.Create((a, b) => a[2] == b[2] ?
                                                                                                a[1].CompareTo(b[1]) :
                                                                                                a[2].CompareTo(b[2])
                                                                                                ));
        // prioritize by processing time, otherwise (if equal) by enqueue time
        int time = 0;
        int ai = 0;
        int ti = 0;
        while (ai < n)
        {
            while (ti < n && extTasks[ti][1] <= time)
            {
                pq.Enqueue(extTasks[ti], extTasks[ti]);
                ti++;
            }
            if (pq.Count == 0)
            {
                time = extTasks[ti][1];
                continue;
            }
            int[] bestFit = pq.Dequeue();
            ans[ai++] = bestFit[0];// write task's index
            time += bestFit[2];// add tasks processing time
        }
        return ans;
    }
}