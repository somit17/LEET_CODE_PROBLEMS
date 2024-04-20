public class Solution {
    public int ClimbStairs(int n) {
        int[] dp = new int[] { 1, 1 };
        int i = 0;
        while (i < n)
        {
            int temp = dp[1];
            dp[1] = dp[0] + dp[1];
            dp[0] = temp;
            i += 1;
        }

        return dp[0];
    }
}