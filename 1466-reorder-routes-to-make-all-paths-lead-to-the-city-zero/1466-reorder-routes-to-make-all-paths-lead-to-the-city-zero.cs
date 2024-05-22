public class Solution {
    public class NodeDetails
    {
        public int dest { get; set; }
        public int original { get; set; }
    }

    int count = 0;

    public int MinReorder(int n, int[][] connections)
    {
        var adjList = new Dictionary<int, List<NodeDetails>>(); //src:dest:original:1else 0
        for(int i=0;i<n;i++){
            adjList[i]=new List<NodeDetails>();
        }
        foreach (var con in connections)
        {
            int src = con[0], dest = con[1];
            adjList[src].Add(new NodeDetails() { dest = dest, original = 1 });
            adjList[dest].Add(new NodeDetails() { dest = src, original = 0 });
        }

        bool[] visited = new bool[n];
        Array.Fill(visited,false);
        DFS(0, adjList, connections, visited);
        return count;
    }

    public void DFS(int u, Dictionary<int, List<NodeDetails>> adj, int[][] connections, bool[] visited)
    {
        visited[u] = true;
        foreach (var nodeData in adj[u])
        {
            int v = nodeData.dest, original = nodeData.original;
            if (!visited[v]){
                count += original;
                DFS(v, adj, connections, visited);
            }

        }
    }
}