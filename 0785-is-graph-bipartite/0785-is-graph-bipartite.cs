public class Solution {
   public bool IsBipartite(int[][] graph)
    {
        
        int[] color = new int[graph.Length];
        System.Array.Fill(color, -1);
        int currentColor = 0; //0->Blue,1->Red
        for (int i = 0; i < graph.Length; i++)
            if (color[i] == -1)
                if (!DFS(graph, i, color, currentColor))
                    return false;
        return true;
    }

    public bool DFS(int[][] adjList, int u, int[] color, int currentColor)
    {
        color[u] = currentColor;
        foreach (var v in adjList[u])
        {
            if (color[v] == color[u])
                return false;
            if (color[v] == -1)
            {
                color[v] = currentColor == 0 ? 1 : 0;
                if (!DFS(adjList, v, color, color[v]))
                    return false;
            }
        }

        return true;
    }
}