public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> result = new List<int>();
        int count = 0;
        Dictionary<int, List<int>> adjList = new();
        int[] indegree = new int[numCourses];
        System.Array.Fill(indegree, 0);

        // Initialize adjacency list and indegree array
        for (int i = 0; i < numCourses; i++)
        {
            adjList[i] = new List<int>();
        }

        // Build the graph
        foreach (var prereq in prerequisites)
        {
            int src = prereq[1], dest = prereq[0];
            adjList[src].Add(dest);
            indegree[dest]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < indegree.Length; i++)
            if (indegree[i] == 0)
            {
                queue.Enqueue(i);
                result.Add(i);
                count++;
            }

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            foreach (var v in adjList[currentNode])
            {
                indegree[v]--;
                if (indegree[v] == 0)
                {
                    count++;
                    result.Add(v);
                    queue.Enqueue(v);
                }
            }
        }

        if (count == numCourses) return result.ToArray();
        return [];
    }
}