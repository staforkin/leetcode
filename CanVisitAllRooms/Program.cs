var solution = new Solution();
var rooms = new List<IList<int>>() { new[] { 1, 3 }, new[] { 3, 0, 1 }, new[] { 2 }, new int[] { 0 } };

Console.WriteLine(solution.CanVisitAllRooms(rooms));
// https://leetcode.com/problems/keys-and-rooms/
public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        // 0 1 2 3
        // 1 2 3 -
        var queue = new Queue<int>();//q to hold keys
        var n = rooms.Count;
        var visited = new int[n];
        visited[0] = 1;//we always can visit first room
        foreach (var item in rooms[0])
        {
            queue.Enqueue(item);
        }

        while (queue.Any() && visited.Sum() < n)
        {
            var i = queue.Dequeue();
            visited[i] = 1;
            foreach (var item in rooms[i])
            {
                if (visited[item] == 0)
                {
                    queue.Enqueue(item);
                }
            }
        }

        return visited.Sum() == n;
    }
}