var solution = new Solution();
Console.WriteLine(solution.CountMatches(new[]{
new List<string>(){"phone","blue","pixel"},
new List<string>(){"computer","silver","lenovo"},
new List<string>(){"phone","gold","iphone"}},
"color", "silver"));

// https://leetcode.com/problems/count-items-matching-a-rule
public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int res = 0;
        int i = ruleKey switch
        {
            "type" => 0,
            "color" => 1,
            "name" => 2,
            _ => -1
        };
        if (i == -1)
        {
            return res;
        }
        foreach (var item in items)
        {
            if (item[i] == ruleValue)
            {
                res++;
            }
        }
        return res;
    }
}