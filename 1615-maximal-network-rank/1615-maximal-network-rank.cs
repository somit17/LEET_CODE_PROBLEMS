public class Solution {
    public int MaximalNetworkRank(int n, int[][] roads) {
        int[] degree = new int[n];
        bool[,] connected = new bool[n, n];
        
        foreach (var road in roads) {
            int u = road[0];
            int v = road[1];
            
            degree[u]++;
            degree[v]++;
            
            connected[u, v] = true;
            connected[v, u] = true;
        }
        
        int maxRank = 0;
        
        for (int i = 0; i < n; i++) {
            for (int j = i+1; j < n; j++) {
                
                int i_rank = degree[i];
                int j_rank = degree[j];
                
                int rank   = i_rank + j_rank;
                
                if (connected[i, j]) {
                    rank -= 1;
                }
                
                maxRank = Math.Max(maxRank, rank);
                
            }
        }
        
        return maxRank;
    }
}