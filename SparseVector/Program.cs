using System;

namespace SparseVectorProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            SparseVector v1 = new SparseVector(new[] { 1, 0, 0, 2, 3 });
            SparseVector v2 = new SparseVector(new[] { 0, 3, 0, 4, 0 });
            int ans = v1.DotProduct(v2);
            Console.WriteLine(ans);
        }
    }

    public class SparseVector
    {
        public SparseVector(int[] nums)
        {
            Nums = nums;
        }
        public int[] Nums;
        public int DotProduct(SparseVector vec)
        {
            int result = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                result+=Nums[i]*vec.Nums[i];
            }
            return result;
        }
    }
}