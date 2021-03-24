using System;
using System.Collections.Generic;

namespace RemoveInvalidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> result = RemoveInvalidParenthesesImpl("()())()");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static IList<string> RemoveInvalidParenthesesImpl(string s){
            int i = 0;
            
            for (int j = 0; j < length; j++)
            {
                if(s[j]=="("){
                    i--;
                } else if (s[j]==")"){
                    i++;
                }
                if(i>1){

                }
            }
        }
    }
}
