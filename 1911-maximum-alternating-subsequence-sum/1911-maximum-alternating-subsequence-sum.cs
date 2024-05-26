public class Solution {
    public long MaxAlternatingSum(int[] nums) {
        int n=nums.Length;
        long[][] mem = new long[n + 1][]; // Initialize a jagged array
        for (int i = 0; i <= n; i++) {
            mem[i] = new long[2]; // Initialize each subarray
            for (int j = 0; j < 2; j++) {
                mem[i][j] = -1; // Use -1 to indicate uninitialized state
            }
        }
        return Solve(nums,mem,0,true);
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