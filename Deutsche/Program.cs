//Find all permutations of elements of in a given array [‘a’, ‘b’, ‘c’, ‘d’] 
// abcd
// bacd
// 4 * 3 * 2 * 1 
// n * (n-1) * .. .. * 1 

// a b c d
// 
// a a a     b b b
// b c d     a c d
//

var p = new Solution();
foreach (var r in p.Permutations(new[] { 'a', 'b', 'c' }))
{
    Console.WriteLine(string.Join(',', r));
}


class Solution
{
    public List<IList<char>> Permutations(char[] input)
    {
        IList<IList<char>> list = new List<IList<char>>();
        backtrack(list, new List<char>(), input);
        return list.ToList();
    }

    public void backtrack(IList<IList<char>> list, List<char> tempList, char[] input){
        if (tempList.Count() == input.Length)
        {
            list.Add(new List<char>(tempList));
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (tempList.Contains(input[i])) continue; // element already exists, skip
                tempList.Add(input[i]);
                backtrack(list, tempList, input);
                //tempList.RemoveAt(tempList.Count() - 1);
            }
        }
    }
}