public class Solution {
    public int[] rank;
    public int[] parent;

    public int MakeConnected(int n, int[][] connections)
    {
        if (connections.Length < n - 1)
            return -1;
        rank = new int[n];
        System.Array.Fill(rank,0);
        parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;
        int components = n;
        foreach (var connection in connections)
        {
            if (Find(connection[0]) != Find(connection[1]))
            {
                components--;
                Union(connection[0],connection[1]);
            }
        }

        return components-1;
    }

    public int Find(int x)
    {
        if (parent[x] == x)
            return x;
        return parent[x] = Find(parent[x]);
    }

    public void Union(int x, int y)
    {
        int xp = Find(x), yp = Find(y);
        if (rank[xp] > rank[yp])
            parent[yp] = xp;
        else if (rank[yp] > rank[xp])
            parent[xp] = yp;
        else
        {
            parent[xp] = yp;
            rank[yp]++;
        }
    }
}