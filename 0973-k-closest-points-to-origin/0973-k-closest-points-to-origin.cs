public class Solution {
    public int[][] KClosest(int[][] points, int k) {
         var pq = new PriorityQueue<List<int>, double>(); //points:sq
        foreach (var pairPoint in points)
        {
            int x = pairPoint[0], y = pairPoint[1];
            pq.Enqueue(new List<int>(pairPoint), (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))));
        }

        int[][] res = new int[k][];
        int i = 0;
        while (k > 0)
        {
            var data = pq.Dequeue();
            res[i++] = data.ToArray();
            k--;
        }

        return res;
    }
}