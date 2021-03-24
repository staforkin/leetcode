using System;
using System.Collections.Generic;

namespace LeftMostColumnWithOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //[[1,1,1,1,1],[0,0,0,1,1],[0,0,1,1,1],[0,0,0,0,1],[0,0,0,0,0]]
            var matInput = new[] { new[] { 0, 0, 0, 1, 1 }, new[] { 0, 0, 1, 1, 1 }, new[] { 0, 0, 0, 0, 1 }, new[] { 0, 0, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 } };
            var mat = new BinaryMatrix(matInput);
            foreach (var item in matInput)
            {
                Console.WriteLine(string.Join(" ", item));
            }
            Console.Write(LeftMostColumnWithOneImpl(mat));
        }
        public static int LeftMostColumnWithOneImpl(BinaryMatrix binaryMatrix)
        {
            var rowsCount = binaryMatrix.Dimensions()[0];
            var colsCount = binaryMatrix.Dimensions()[1];
            int result = -1;
            int r = 0;
            int c = colsCount - 1;
            while (r < rowsCount && c > -1)
            {
                if (binaryMatrix.Get(r, c) == 1)
                {
                    result = c;
                    c--;
                }
                else
                {
                    r++;
                }
            }
            return result;
        }
    }
    public class BinaryMatrix
    {
        private IList<int> dimensions { get; }
        private int[][] mat { get; }
        public BinaryMatrix(int[][] matInput)
        {
            mat = matInput;
            dimensions = new List<int>();
            foreach (var item in matInput)
            {
                dimensions.Add(item.Length);
            }
        }
        public int Get(int row, int col)
        {
            return mat[row][col];
        }
        public IList<int> Dimensions()
        {
            return new[] { mat.Length, mat[0].Length };
        }
    }
}
