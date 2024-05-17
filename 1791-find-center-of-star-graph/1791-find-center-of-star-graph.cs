public class Solution {
    public int FindCenter(int[][] edges) {
        int center = 0;
        int[] indegree = new int[edges.Length + 2];
        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1];
            indegree[v]++;
        }

        int maxValue = 0;
        for (int i = 1; i < indegree.Length; i++)
        {
            maxValue = indegree[i];
            center = maxValue > center ? i : center;
        }

        return center;
    }
}