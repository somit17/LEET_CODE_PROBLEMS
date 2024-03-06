public class Solution {
    public int LeastBricks(IList<IList<int>> wall) {
        Dictionary<int, int> countGap = new(); //mapping pos : count of brick gaps
        foreach (var row in wall)
        {
            int total = 0;
            for (int i = 0; i < row.Count - 1; i++)
            {
                total += row[i];
                countGap.TryGetValue(total, out int val);
                countGap[total] = val + 1;
            }
        }
               return wall.Count - (countGap.Values.Count==0 ? 0: countGap.Values.Max());
    }
}