public class Solution {
    public int FindJudge(int n, int[][] trust) {
        Dictionary<int, int> indegree = new();
        Dictionary<int, int> outDegree = new(); //map node with outgoing count
        for (int i = 1; i <= n; i++)
        {
            indegree[i] = 0;
            outDegree[i] = 0;
        }

        foreach (int[] edge in trust)
        {
            int src = edge[0], target = edge[1];
            outDegree[src]++;
       indegree[target] ++;
        }

        foreach (var data in outDegree)
        {
            if (data.Value == 0 && indegree[data.Key]==n-1)
                return data.Key;
        }

        return -1;
    }
}