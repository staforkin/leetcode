public class Program {

    public static int Main(string[] args)
    {
        return LengthOfLongestSubstring("dvdf");
    }

    public static int LengthOfLongestSubstring(string s) {
        int longestSequenceCount = 0;
        List<char> sequence = new List<char>();
        for(int i = 0; i < s.Length; i++)
        {
            if(sequence.Contains(s[i]))
            {
                sequence = sequence.GetRange(sequence.IndexOf(s[i]+1), sequence.Count - sequence.IndexOf(s[i]+1));
            }
            sequence.Add(s[i]);
            longestSequenceCount = Math.Max(longestSequenceCount, sequence.Count);
        }
        return longestSequenceCount;        
    }
}