using System;
using System.Collections.Generic;

namespace KClosest
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new[] { new[] { 3, 3 }, new[] { 5, -1 }, new[] { -2, 4 } };
            var result = KClosestImpl(points, 2);
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
        public static int[][] KClosestImpl(int[][] points, int k)
        {
            var length = points.Length;
            var dists = new int[length];
            for (int i = 0; i < length; i++)
            {
                dists[i] = GetDistance(points[i]);
            }
            Array.Sort(dists);
            int distK = dists[k-1];

            var res = new int[k][];
            int t=0;
            for (int i = 0; i < length; i++)
            {
                if(GetDistance(points[i])<=distK)
                {
                    res[t++]=points[i];
                }
            }
            return res;
        }
        private static int GetDistance(int[] point)
        {
            return point[0] * point[0] + point[1] * point[1];
        }
    }
}
