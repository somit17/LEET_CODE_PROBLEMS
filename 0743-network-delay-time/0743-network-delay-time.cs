public class Solution {
    public int NetworkDelayTime(int[][] times, int nodes, int k) {
       Dictionary<int, List<int[]>> adjacencyList = new();
        for (int i = 1; i <= nodes + 1; i++)
            adjacencyList[i] = new List<int[]>();

        foreach (var edge in times)
        {
            int s = edge[0], d = edge[1], w = edge[2];
            adjacencyList[s].Add(new[] { d, w });
        }

        Dictionary<int, int> shortestDistances = new Dictionary<int, int>();
        var pq = new PriorityQueue<(int, int), int>();
        pq.Enqueue((0, k), 0);
        while (pq.Count > 0)
        {
            var (currWeight, node) = pq.Dequeue();
            if (!shortestDistances.ContainsKey(node))
            {
                shortestDistances[node] = currWeight;
                if (adjacencyList.ContainsKey(node))
                {
                    foreach (var next in adjacencyList[node])
                    {
                        var nextNode = next[0];
                        var edgeWeight = next[1];
                        var newDist = currWeight + edgeWeight;
                        pq.Enqueue((newDist, nextNode), newDist);
                    }
                }
            }
        }

        // Check for unreachable nodes
        int reachableNodes = shortestDistances.Count(kv => kv.Value != int.MaxValue);
        if (reachableNodes < nodes)
        {
            return -1; // There are unreachable nodes
        }

        // Find the maximum time among all shortest paths
        int maxTime = shortestDistances.Values.Max();

        // Return the maximum time
        return maxTime; 
    }
}