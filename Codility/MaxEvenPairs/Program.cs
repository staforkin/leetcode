using System;

namespace MaxEvenPairs
{
    class Program
    {
        /*
        You are given N numbers on a circle, described by an array A. Find the maximum number of neighbouring pairs whose sums are even. One element can belong to only one pair.
        Write a function:
        class Solution { public int solution(int[] A); }
        that, given an array A consisting of N integers, returns the maximum number of neighbouring pairs whose sums are even.
        Examples:
        1. Given A = [4, 2, 5, 8, 7, 3, 7], the function should return 2. We can create two pairs with even sums: (A[0], A[1]) and (A[4], A[5]). Another way to choose two pairs is: (A[0], A[1]) and (A[5], A[6]).
        https://codility-frontend-prod.s3.amazonaws.com/media/task_static/even_pairs_on_cycle/static/images/auto/7bcdb65fc180c96c1b99dbebf004b92c.png
        2. Given A = [14, 21, 16, 35, 22], the function should return 1. There is only one qualifying pair: (A[0], A[4]).
        https://codility-frontend-prod.s3.amazonaws.com/media/task_static/even_pairs_on_cycle/static/images/auto/f776e66233614f10b25fae9951eb7745.png
        3. Given A = [5, 5, 5, 5, 5, 5], the function should return 3. We can create three pairs: (A[0], A[5]), (A[1], A[2]) and (A[3], A[4]).
        https://codility-frontend-prod.s3.amazonaws.com/media/task_static/even_pairs_on_cycle/static/images/auto/4e146967b89d480a459f10955e2395c2.png
        Write an efficient algorithm for the following assumptions:
        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [0..1,000,000,000].        
        */
        static void Main(string[] args)
        {
            //var arr = new[] { 4, 2, 5, 8, 7, 3, 7 };
            var arr = new[] { 5,5,5,5,5,5 };
            var solution = new Solution();
            Console.WriteLine(solution.solution(arr));
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            var pairs = 0;
            int[] occupied = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                var l = A[i];
                var rIndex = i+1==A.Length?0:i+1;
                if(occupied[i]>0 || occupied[rIndex]>0){
                    continue;
                }
                if(IsEven(l) && IsEven(A[rIndex]) || (!IsEven(l) && !IsEven(A[rIndex]))){
                    Console.WriteLine($"{l};{A[rIndex]}");
                    occupied[i]++;
                    occupied[rIndex]++;
                    pairs++;
                }
            }
            return pairs;
        }

        private bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }
}
