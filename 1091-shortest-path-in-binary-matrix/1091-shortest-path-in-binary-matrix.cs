public class Solution {
    public class P
    {
        public int Distance { get; set; }
        public (int, int) Pair { get; set; }

        public P(int distance, (int, int) pair)
        {
            Distance = distance;
            Pair = pair;
        }
    }

    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        int[][] directions = new int[][]
        {
            new int[] { 1, 1 }, new int[] { 0, 1 }, new int[] { 1, 0 },
            new int[] { 0, -1 }, new int[] { -1, 0 }, new int[] { -1, -1 },
            new int[] { 1, -1 }, new int[] { -1, 1 }
        };

        int row = grid.Length, cols = grid[0].Length;
        if (row == 0 || cols == 0 || grid[0][0] != 0 || grid[row - 1][cols - 1] != 0)
            return -1;

        int[][] result = new int[row][];
        for (int i = 0; i < row; i++)
        {
            result[i] = new int[cols];
            System.Array.Fill(result[i], Int32.MaxValue);
        }

        bool IsSafe(int x, int y)
        {
            return x >= 0 && x < row && y >= 0 && y < cols;
        }

        var pq = new PriorityQueue<P, int>();
        pq.Enqueue(new P(distance: 1, pair: (0, 0)), 1);
        result[0][0] = 1;

        while (pq.Count > 0)
        {
            var data = pq.Dequeue();
            int distance = data.Distance;
            var (x, y) = data.Pair;

            if (x == row - 1 && y == cols - 1) return distance; // Found the shortest path

            foreach (var dir in directions)
            {
                int x_ = x + dir[0];
                int y_ = y + dir[1];
                int newDistance = distance + 1;

                if (IsSafe(x_, y_) && grid[x_][y_] == 0 && newDistance < result[x_][y_])
                {
                    pq.Enqueue(new P(distance: newDistance, pair: (x_, y_)), newDistance);
                    result[x_][y_] = newDistance;
                }
            }
        }

        return -1; // No path found
    }
}