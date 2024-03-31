public class Solution {
    public int DeleteGreatestValue(int[][] grid) {
        List<PriorityQueue<int, int>> pqList = new();
        for (int row = 0; row < grid.Length; row++)
        {
            var pq = new PriorityQueue<int, int>();
            for (int col = 0; col < grid[row].Length; col++)
            {
                pq.Enqueue(grid[row][col], grid[row][col]);
            }

            pqList.Add(pq);
        }

        int res = 0;
        while (pqList.Count > 0 && pqList[0].Count>0)
        {
            int max = 0;
            for (int row = 0; row < grid.Length; row++)
            {
                max= Math.Max(pqList[row].Dequeue(), max);
            }

            res += max;
        }

        return res;
    }
}