public class Solution {
    public class Point
    {
        public int node { get; set; }
        public int weight { get; set; }
    }
    public int MinCostConnectPoints(int[][] points) {
        Dictionary<int, List<Point>> adjList = new Dictionary<int, List<Point>>();
        for (int i = 0; i < points.Length; i++)
        {
            adjList[i] = new List<Point>();
        }

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                int x1 = points[i][0], y1 = points[i][1];
                int x2 = points[j][0], y2 = points[j][1];
                int dist = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                adjList[i].Add(new Point() { node = j, weight = dist });
                adjList[j].Add(new Point() { node = i, weight = dist });
            }
        }

        return PrimsAlgo(points.Length, adjList);
    }
    public int PrimsAlgo(int V, Dictionary<int, List<Point>> adjList)
    {
        var pq = new PriorityQueue<Point, int>();
        bool[] inMST = new bool[V];
        System.Array.Fill(inMST,false);
        pq.Enqueue(new Point() { node = 0, weight = 0 }, 0);
        int sum = 0;
        while (pq.Count>0)
        {
            var nodeData = pq.Dequeue();
            int node = nodeData.node;
            int wt = nodeData.weight;
            if(inMST[node])
                continue;
            inMST[node] = true;
            sum += wt;
            foreach (var v in adjList[node])
            {
                int neighbor = v.node;
                int neighbor_wt = v.weight;
                if (!inMST[neighbor])
                {
                    pq.Enqueue(new Point() { node = neighbor, weight = neighbor_wt }, neighbor_wt);
                }
            }
        }

        return sum;
    }
}