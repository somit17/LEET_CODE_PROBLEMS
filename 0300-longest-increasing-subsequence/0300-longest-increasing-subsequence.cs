public class Solution {
    public int LengthOfLIS(int[] nums) {
        int maxLis=1,n=nums.Length;
        int[] dp=new int[n];
        Array.Fill(dp,1);
        for(int i=0;i<n;i++){
           for(int j=0;j<i;j++){
                if(nums[i]>nums[j]){
                    dp[i]=Math.Max(dp[i], dp[j]+1);     
                    maxLis=Math.Max(dp[i], maxLis);     
                }
            } 
        }
        return maxLis;
    }
    public int Solve(int[] nums,int[][] mem,int i,int prev){
        if (i >= nums.Length)
            return 0;
        if (prev != -1 && mem[i][prev] != -1)
            return mem[i][prev];
        int take = 0, skip = 0;
        if (prev == -1 || nums[i] > nums[prev])
            take = 1 + Solve(nums, mem, i + 1, i);
        skip = Solve(nums, mem, i + 1, prev); // Skip
        if (prev != -1) {
            mem[i][prev] = Math.Max(skip, take);
        }
        return Math.Max(skip, take);
    }
}