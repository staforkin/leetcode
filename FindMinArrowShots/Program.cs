var solution = new Solution();
var arr = new int[][] {
    new int[] { 7, 10 },
    new int[] { 1, 5 },
    new int[] { 3, 6 },
    new int[] { 2, 4 } };
Console.WriteLine(solution.FindMinArrowShots(arr));

// https://leetcode.com/problems/minimum-number-of-arrows-to-burst-balloons
public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        // 0 1 2 3 4 5 6 7 8 9 10
        //     [   ]
        //   [     ]
        //   [       ]
        //       [     ]
        //                [    ]
        // arrows
        //         |
        //                     |

        if (points.Length == 0)
        {
            return 0;
        }
        Array.Sort(points, Comparer<int[]>.Create((a, b) => a[1].CompareTo(b[1])));
        int arrowPos = points[0][1];
        int arrowCnt = 1;
        for (int i = 1; i < points.Length; i++)
        {
            if (arrowPos >= points[i][0])
            {
                continue;
            }
            arrowCnt++;
            arrowPos = points[i][1];
        }
        return arrowCnt;
    }
}