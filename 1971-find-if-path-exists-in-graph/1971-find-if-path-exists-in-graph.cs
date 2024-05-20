public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
      //Step 1: Create adj List
        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
        for (int i = 0; i < n; i++)
        {
            adjList[i] = new List<int>();
        }
        foreach (var edge in edges)
        {
            int src = edge[0], dest = edge[1];
            adjList[src].Add(dest);
            adjList[dest].Add(src);
        }
        //Start BFS
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[n];
        System.Array.Fill(visited,false);
        queue.Enqueue(source);
        visited[source] = true;
        while (queue.Count > 0)
        {
             var currentNode = queue.Dequeue();
             if (currentNode == destination)
                return true;
            foreach (var v in adjList[currentNode])
            {
                if (!visited[v])
                {
                    queue.Enqueue(v);
                    visited[v] = true;
                }
            }
        }

        return false;  
    }
}