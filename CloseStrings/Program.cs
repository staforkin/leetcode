var solution = new Solution();
Console.WriteLine(solution.CloseStrings("cabbba","abbccc"));
// https://leetcode.com/problems/determine-if-two-strings-are-close
public class Solution {
    public bool CloseStrings(string word1, string word2) {
        // cabbba -> caabbb
        // caabbb -> baaccc
        // baaccc -> abbccc
        if(word1.Length!=word2.Length){
            return false;
        }
        var hs1= new HashSet<char>(word1);
        var hs2= new HashSet<char>(word2);
        if(hs1.Count!=hs2.Count){
            return false;
        }
        foreach (var c in hs1)
        {
            if(!hs2.Contains(c)){
                return false;
            }
        }
        return true;
    }
}