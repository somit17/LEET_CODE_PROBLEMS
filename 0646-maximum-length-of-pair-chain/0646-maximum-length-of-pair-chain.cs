public class Solution {
   
    public int FindLongestChain(int[][] nums) {
        int n=nums.Length;
        int maxLis=1;
        Array.Sort(nums, (a, b) => a[1].CompareTo(b[1]));
        int[] dp=new int[n];
        Array.Fill(dp,1);
        for(int i=0;i<n;i++){
           for(int j=0;j<i;j++){
                if(nums[i][0]>nums[j][1]){
                    dp[i]=Math.Max(dp[i], dp[j]+1);     
                    maxLis=Math.Max(dp[i], maxLis);     
                }
            } 
        }
        return maxLis;
    }
    
    
    
    /* Memoization
    public int FindLongestChain(int[][] pairs) {
        int n=pairs.Length;
        int[][] mem = new int[pairs.Length + 1][];
        for (int i = 0; i < pairs.Length + 1; i++) {
            mem[i] = new int[pairs.Length]; // Change the size of the second dimension
            for (int j = 0; j < pairs.Length; j++) {
                mem[i][j] = -1;
            }
        }
        // Sort pairs by the second element
        Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));
        return Solve(pairs,mem,0,-1);
    }

    public int Solve(int[][] nums,int[][] mem,int i,int prev){
        if (i >= nums.Length)
            return 0;
        if (prev != -1 && mem[i][prev] != -1)
            return mem[i][prev];
        int take = 0, skip = 0;
        if (prev == -1 || nums[i][0] > nums[prev][1])
            take = 1 + Solve(nums, mem, i + 1, i);
        skip = Solve(nums, mem, i + 1, prev); // Skip
        if (prev != -1) {
            mem[i][prev] = Math.Max(skip, take);
        }
        return Math.Max(skip, take);
    }*/
}