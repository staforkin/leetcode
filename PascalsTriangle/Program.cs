var solution = new Solution();
foreach(var list in solution.Generate(5)){
    Console.WriteLine(string.Join(",", list));
}

//https://leetcode.com/problems/pascals-triangle
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>(numRows);
        for (int i = 0; i < numRows; i++)
        {
            result.Add(new List<int>(new int[i+1]));
            result[i][0]=1;
            result[i][i]=1;
            for (int j = 1; j < i; j++)
            {
                result[i][j]=result[i-1][j-1] + result[i-1][j];
            }
        }
        return result;
    }
}