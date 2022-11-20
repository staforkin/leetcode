using System.Text;

var solution = new Solution();
Console.WriteLine(solution.CountAndSay(4));

// https://leetcode.com/problems/count-and-say
public class Solution {
    public string CountAndSay(int n) {
        string s = "1";
        while(n>1){
            s = helper(s);
            n--;
        }
        return s;
    }
    
    private string helper(string s){
        // 11 two ones => 21
        // 21 one two one one => 1211
        char prevChar = s[0];
        int counter = 0;
        var dict = new List<(char,int)>();
        bool wasAdded = false;
        foreach (var c in s)
        {
            if(prevChar == c){
                counter++;
                wasAdded = false;
            } else {
                //update dict
                dict.Add((prevChar,counter));
                //reset counter and prevChar
                counter = 1;
                prevChar = c;
            }
        }
        if(!wasAdded){
            dict.Add((prevChar,counter));
        }
        var sb = new StringBuilder();
        foreach (var i in dict)
        {
            sb.Append($"{i.Item2}{i.Item1}");
        }
        return sb.ToString();
    }
}