var solution = new Solution();
Console.WriteLine(solution.HalvesAreAlike("textbook"));

// https://leetcode.com/problems/determine-if-string-halves-are-alike
public class Solution {
    public bool HalvesAreAlike(string s) {
        // bbobab
        var vowels = new HashSet<char>(new []{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'});
        int left = 0, right = s.Length-1;
        int leftCount = default, rightCount = default;
        while(right>left){
            if(vowels.Contains(s[left])){
                leftCount++;
            }
            if(vowels.Contains(s[right])){
                rightCount++;
            }
            left++;
            right--;
        }
        return leftCount == rightCount;
    }
}