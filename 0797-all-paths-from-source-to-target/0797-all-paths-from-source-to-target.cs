public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
       if (graph == null || graph.Length == 0)
            return res;
        DFS(graph, 0, new List<int>());
        return res;  
    }
    private void DFS(int[][] graph, int currentNode, List<int> path)
    {
        path.Add(currentNode);
        if (currentNode == graph.Length - 1)
            res.Add(new List<int>(path));
        else
            foreach (var node in graph[currentNode])
                DFS(graph, node, path);
        path.Remove(currentNode);
    }
}