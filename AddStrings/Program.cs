﻿using System;

namespace AddStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "111", num2 ="222";
            Console.WriteLine(AddStringsImpl(num1, num2));
        }

        public static string AddStringsImpl(string num1, string num2) {
            int overFlow = 0;
            int l1 = num1.Length;
            int l2 = num2.Length;
            
        }
    }
}