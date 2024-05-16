public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        var pq1 = new PriorityQueue<int, int>();
        var pq2 = new PriorityQueue<int, int>();
        int i = 0, j = costs.Length - 1;
        long hired = 0, ans = 0;
        while (hired < k)
        {
            while (pq1.Count < candidates && i <= j)
            {
                pq1.Enqueue(costs[i], costs[i]);
                i++;
            }

            while (pq2.Count < candidates && j >= i)
            {
                pq2.Enqueue(costs[j], costs[j]);
                j--;
            }

            long minPQ1 = pq1.Count > 0 ? pq1.Peek() : int.MaxValue;
            long minPQ2 = pq2.Count > 0 ? pq2.Peek() : int.MaxValue;
            if (minPQ1 <= minPQ2)
            {
                ans += minPQ1;
                pq1.Dequeue();
            }
            else
            {
                ans += minPQ2;
                pq2.Dequeue();
            }

            hired++;
        }
        return ans;
    }
}