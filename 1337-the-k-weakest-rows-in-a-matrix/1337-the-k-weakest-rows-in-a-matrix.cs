public class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
           List<int> lstSoldierCount = new();
        for (int i = 0; i < mat.Length; i++)
        {
            int soldierCount = 0;
            for (int j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 1) soldierCount++;
            }

            lstSoldierCount.Add(soldierCount);
        }

        var pq = new PriorityQueue<int, int>();
        for (int i = 0; i < lstSoldierCount.Count; i++)
        {
            pq.Enqueue(i, lstSoldierCount[i]);
        }

        List<int> res = new();
        var data = pq.UnorderedItems.OrderBy(x => x.Priority).ThenBy(x => x.Element).Take(k).ToList();
        foreach (var item in data)
        {
            res.Add(item.Element);
        }
        return res.ToArray();   
    }
}