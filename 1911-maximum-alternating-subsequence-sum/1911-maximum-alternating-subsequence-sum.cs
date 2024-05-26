public class Solution {
    public long MaxAlternatingSum(int[] nums) {
        int n = nums.Length;
        long[][] bottomUp = new long[n + 1][]; // Initialize a jagged array
        for (int i = 0; i < n + 1; i++) {
            bottomUp[i] = new long[2]; // Initialize each subarray
            for (int j = 0; j < 2; j++) {
                bottomUp[i][j] = 0; // Initialize to 0
            }
        }

        // Initialize base case
        bottomUp[0][0] = 0; // Even length subsequence sum starting at -1 is 0
        bottomUp[0][1] = 0; // No valid odd length subsequence at the start

        for (long i= 1; i <= n; i++) {
            bottomUp[i][0] = Math.Max(bottomUp[i - 1][1] - nums[i - 1], bottomUp[i - 1][0]); // Even length subsequence
            bottomUp[i][1] = Math.Max(bottomUp[i - 1][0] + nums[i - 1], bottomUp[i - 1][1]); // Odd length subsequence
        }

        return Math.Max(bottomUp[n][0], bottomUp[n][1]);
    }
    long Solve(int[] nums,long[][] mem,int idx,bool isEven){
        if(idx >= nums.Length)
            return 0;
        int evenOdd = isEven ? 0 : 1; // Convert boolean to 0 or 1 for indexing
        if(mem[idx][evenOdd]!=-1)
            return mem[idx][evenOdd];
        long Skip = Solve(nums,mem,idx+1,isEven);
        long val=nums[idx];
        val=!isEven?-val:val;
        long Take=Solve(nums,mem,idx+1,!isEven)+val;
        mem[idx][evenOdd]=Math.Max(Skip,Take);
        return mem[idx][evenOdd];
    }
}