using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDupsFromSortedArray
{
    class Program
    {
        static int Main(string[] args)
        {
            var input = new []{1,1,2};
            var res = RemoveDups(input);
            foreach (var item in input)
            {
                Console.Write(item);
            }
            return res;
        }
        static int RemoveDups(int[] input){
            var prev = 10001;
            var res = 0;
            var exceptIndeces = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]==prev){
                    exceptIndeces.Add(i);
                }
                else
                {
                    prev = input[i];
                    res++;
                }
                
            }
            input = input.Except(exceptIndeces).ToArray();
            return res;
        }
    }
}
