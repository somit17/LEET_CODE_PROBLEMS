public class Solution {
    public int MaxProfit(int[] prices) {
                int n = prices.Length;
        int cp = 0, maxProfit = 0, min = prices[0];
        for (int i = 1; i < n; i++)
        {
            cp = prices[i] - min;
            maxProfit = Math.Max(cp, maxProfit);
            min = Math.Min(min, prices[i]);
        }
        return maxProfit;
    }
}