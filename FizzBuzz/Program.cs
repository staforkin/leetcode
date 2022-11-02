var solution = new Solution();
foreach(var r in solution.FizzBuzz(15)){
    Console.WriteLine(r);
}

// https://leetcode.com/problems/fizz-buzz
public class Solution {
    public IList<string> FizzBuzz(int n) {
        var result = new List<string>();
        for(int i = 1; i<=n; i++){            
            if(DivisibleBy(i,3) && DivisibleBy(i,5)){
                result.Add("FizzBuzz");
            } else if (DivisibleBy(i,3)){
                result.Add("Fizz");
            } else if (DivisibleBy(i,5)){
                result.Add("Buzz");
            } else {
                result.Add(i.ToString());
            }
        }
        return result;
    }

    bool DivisibleBy(int input, int devider){
        return input % devider == 0;
    }
}