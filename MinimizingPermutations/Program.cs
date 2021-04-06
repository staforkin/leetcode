using System;
using System.Linq;
using System.Collections.Generic;

namespace MinimizingPermutations
{
    class Program
    {
        private static HashSet<string> visited = new HashSet<string>();
        static void Main(string[] args)
        {
            //https://www.facebookrecruiting.com/portal/coding_practice_question/?problem_id=292715105029046
            var arr = new[] { 3, 1, 2 };
            Console.Write(minOperations(arr));
        }
        private static int minOperations(int[] arr)
        {
            if (arr == null || arr.Length <= 1 || isSorted(arr)) return 0;

            Queue<KeyValuePair<int[], int>> queue = new Queue<KeyValuePair<int[], int>>();
            queue.Enqueue(new KeyValuePair<int[], int>(arr, 0));

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                String s = string.Join("", item.Key.Select(i => i.ToString()));
                if (visited.Contains(s))
                {
                    continue;
                }
                visited.Add(s);

                for (int x = 0; x < item.Key.Length; x++)
                {
                    for (int y = x + 1; y < item.Key.Length; y++)
                    {
                        var copy = new int[item.Key.Length];
                        Array.Copy(item.Key,copy, item.Key.Length);
                        int[] n = reverse(copy, x, y);
                        if (isSorted(n))
                        {
                            return item.Value + 1;
                        }
                        queue.Enqueue(new KeyValuePair<int[],int>(n, item.Value + 1));
                    }
                }
            }
            return -1;
        }

        private static int[] reverse(int[] arr, int start, int end)
        {
            for (int x = 0; x <= (end - start) / 2; x++)
            {
                int temp = arr[start + x];
                arr[start + x] = arr[end - x];
                arr[end - x] = temp;
            }
            return arr;
        }
        private static bool isSorted(int[] arr)
        {
            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] != x + 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
