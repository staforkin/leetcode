var solution = new Solution();
Console.WriteLine(solution.NumRescueBoats(new[] { 3, 2, 2, 1 }, 3));

// https://leetcode.com/problems/boats-to-save-people
public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        int boatCount = 0;
        Array.Sort(people);

        int left = 0;
        int right = people.Length - 1;

        while (left <= right)
        {
            int sum = people[left] + people[right];
            if (sum <= limit)
            {
                boatCount++;
                left++;
                right--;
            }
            else
            {
                boatCount++;
                right--;
            }
        }
        return boatCount;
    }
}