using System;
using System.Collections.Generic;

namespace ReverseInt
{
    class Program
    {
        public static void Main(string[] args) {
         
            int[] vs = new int[] { 1, 2, 2, 3 };   // you can write to stdout for debugging purposes, e.g.
            var dist = DistinctWithSourceOrdering(vs);
            foreach (var item in dist)
            {
                Console.Write(item);
            }
        }
        
        public static IEnumerable<T> DistinctWithSourceOrdering<T>(IEnumerable<T> source) where T : IEquatable<T>
        {
            T prevItem = null;
            foreach (var item in source){
                if (prevItem == null)
                {
                    prevItem = item;
                    yield return item;
                    continue;
                }

                if (item == prevItem)
                    continue;
                
                prevItem = item;
                yield return item;
            }            
        }
    }
}
