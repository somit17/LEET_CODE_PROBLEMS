public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[][] mem=new int[nums.Length+1][];
        for(int i=0;i<nums.Length+1;i++){
            mem[i]=new int[nums.Length];
            for(int j=0;j<nums.Length;j++){
                 mem[i][j]=-1;
            }
        }
        return Solve(nums,mem,0,-1);
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