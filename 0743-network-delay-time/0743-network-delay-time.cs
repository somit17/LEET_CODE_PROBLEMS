public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
      Dictionary<int, List<int[]>> adjList = new();
        for (int i = 1; i <= n; i++)
        {
            adjList[i] = new List<int[]>();
        }

        foreach (var time in times)
        {
            int src = time[0], dest = time[1], cost = time[2];
            adjList[src].Add(new[]
            {
                dest, cost
            });
        }

        int[] distance = new int[n + 1];
        System.Array.Fill(distance, int.MaxValue);

        //PriorityQUeue //dest:cost:priority
        var pq = new PriorityQueue<(int, int), int>();
        distance[k] = 0;
        pq.Enqueue((k, 0), 0);
        while (pq.Count > 0)
        {
            var (node, cost) = pq.Dequeue();
            foreach (var v in adjList[node])
            {
                int newNode = v[0], dist = v[1];
                int newDistance = dist + cost;
                if (newDistance < distance[newNode])
                {
                    distance[newNode] = newDistance;
                    pq.Enqueue((newNode, newDistance), newDistance);
                }
            }
        }

        int result = Int32.MinValue;
        for (int i = 1; i <= n; i++)
        {
            result = Math.Max(result, distance[i]);
        }

        return result == Int32.MaxValue ? -1 : result;
    }
}