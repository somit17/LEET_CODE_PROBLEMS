public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int V = graph.Length;
        List<int> temp = new List<int>();
        int src = 0;
        int target = V - 1;
        DFS(src, target, graph, result, temp);

        return result;
    }

    public void DFS(int u, int target, int[][] graph, IList<IList<int>> result, List<int> temp)
    {
        temp.Add(u);
        if (u == target)
            result.Add(new List<int>(temp));
        else
        {
            foreach (var v in graph[u])
            {
                DFS(v, target, graph, result, temp);
            }
        }
        temp.RemoveAt(temp.Count-1);
    }
}