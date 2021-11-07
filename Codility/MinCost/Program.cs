using System;

namespace MinCost
{
    class Program
    {
        /*
        In one step, any element of a given array can be either increased or decreased by 1.
        Write a function:
        class Solution { public int solution(int[] A); }
        that, given an array A of N integers, returns the minimum number of steps required to make all elements equal.
        Examples:
        1. Given A = [3, 2, 1, 1, 2, 3, 1], the function should return 5. All 1s can be increased by 1 and all 3s can be decreased by 1.
        2. Given A = [4, 1, 4, 1], the function should return 6. All 4s can be decreased by 1 three times.
        3. Given A = [3, 3, 3], the function should return 0. All elements are already the same.
        Write an efficient algorithm for the following assumptions:
        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [1..4].
        */
        static void Main(string[] args)
        {
            var solution = new Solution();
            var arr = new[] { 4, 1, 4, 1 };
            //0 1 2 3
            //1 1 4 4
            //var arr = new[] { 3, 2, 1, 1, 2, 3, 1 };
            //1 1 1 2 2 3 3
            //      |
            //2 2 2 2 2 2 2
            //| | |     | |
            //
            // Output: 5
            Console.WriteLine(solution.solution(arr));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            int steps = 0;
            Array.Sort(A);
            int middleValue = A[A.Length / 2];
            for (int i = 0; i < A.Length; i++)
            {
                steps += Math.Abs(A[i] - middleValue);
            }

            if (A.Length % 2 == 0)
            {
                int newSteps = 0;
                middleValue = A[A.Length / 2 - 1];
                for (int i = 0; i < A.Length; i++)
                {
                    newSteps += Math.Abs(A[i] - middleValue);
                }
                steps = Math.Min(steps, newSteps);
            }
            return steps;
        }
    }
}
