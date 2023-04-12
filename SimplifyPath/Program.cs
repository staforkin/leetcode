using System.Text;

var solution = new Solution();
Console.WriteLine(solution.SimplifyPath("/a/./b/../../c/"));

// 
public class Solution
{
    public string SimplifyPath(string path)
    {
        var s = new Stack<string>();
        var res = new StringBuilder();
        var p = path.Split("/");

        for (int i = 0; i < p.Length; i++)
        {
            if (s.Any() && p[i].Equals(".."))
            {
                s.Pop();
            }
            else if (!p[i].Equals("") && !p[i].Equals(".") && !p[i].Equals(".."))
            {
                s.Push(p[i]);
            }
        }

        if (!s.Any())
        {
            return "/";
        }
        while (s.Any())
        {
            res.Insert(0, s.Pop()).Insert(0, "/");
        }

        return res.ToString();
    }
}