using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace NumberToWords
{
    public class Program
    {
        public static Dictionary<long, string> map = new Dictionary<long, string>(){
            { 0, "Zero"},
            { 1, "One"},
            { 2, "Two"},
            { 3, "Three"},
            { 4, "Four"},
            { 5, "Five"},
            { 6, "Six"},
            { 7, "Seven"},
            { 8, "Eight"},
            { 9, "Nine"},
            { 10, "Ten"},
            { 11, "Eleven"},
            { 12, "Twelve"},
            { 13, "Thirteen"},
            { 14, "Fourteen"},
            { 15, "Fifteen"},
            { 16, "Sixteen"},
            { 17, "Seventeen"},
            { 18, "Eighteen"},
            { 19, "Nineteen"},
            { 20, "Twenty"},
            { 30, "Thirty"},
            { 40, "Fourty"},
            { 50, "Fifty"},
            { 60, "Sixty"},
            { 70, "Seventy"},
            { 80, "Eighty"},
            { 90, "Ninety"},
            { 100, "Hundred"},
            { 1000, "Thousand"},
            { 1000000, "Million"},
            { 1000000000, "Billion"},
            { 1000000000000, "Trillion"}
        };
        public static void Main(string[] args)
        {
            Console.Write(NumberToWordsImpl(123));
        }

        public static string NumberToWordsImpl(int num)
        {
            int billion = num / 1000000000;
            int million = (num - billion * 1000000000) / 1000000;
            int thousand = (num - billion * 1000000000 - million * 1000000) / 1000;
            int rest = num - billion * 1000000000 - million * 1000000 - thousand * 1000;
            String result = "";
            if (billion != 0)
                result = ThousandPartToWords(billion) + " Billion";
            if (million != 0)
            {
                if (!string.IsNullOrWhiteSpace(result))
                    result += " ";
                result += ThousandPartToWords(million) + " Million";
            }
            if (thousand != 0)
            {
                if (!string.IsNullOrWhiteSpace(result))
                    result += " ";
                result += ThousandPartToWords(thousand) + " Thousand";
            }
            if (rest != 0)
            {
                if (!string.IsNullOrWhiteSpace(result))
                    result += " ";
                result += ThousandPartToWords(rest);
            }

            return result;
        }
        private static string ThousandPartToWords(int num)
        {
            if (num < 1)
            {
                return string.Empty;
            }
            var hundreds = num / 100;
            var tens = (num - (hundreds * 100)) / 10;
            var singles = (num - (hundreds * 100) - (tens * 10)) % 10;
            var sb = new StringBuilder();
            if (hundreds > 0)
            {
                sb.Append(map[hundreds]).Append(" Hundred");
            }
            if (tens == 1)
            {// 11, 12, ...
                if(sb.Length>0){
                    sb.Append(" ");
                }
                sb.Append(map[num % 100]);
                return sb.ToString();
            }
            if (tens > 1)
            {
                if(sb.Length>0){
                    sb.Append(" ");
                }
                sb.Append(map[tens * 10]);
            }
            if (singles > 0)
            {
                if(sb.Length>0){
                    sb.Append(" ");
                }
                sb.Append(map[singles]);
            }
            return sb.ToString();
        }
    }
}
