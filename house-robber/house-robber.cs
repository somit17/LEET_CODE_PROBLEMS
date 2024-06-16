public class Solution {
    int[] mem = new int[101];

    public int Rob(int[] nums)
    {
        System.Array.Fill(mem, -1);
        return Solve(nums, 0);
    }

    public int Solve(int[] nums, int i)
    {
        if (i >= nums.Length)
            return 0;
        if (mem[i] != -1)
            return mem[i];
        int steal = nums[i] + Solve(nums, i + 2);
        int skip = Solve(nums, i + 1);
        return mem[i] = Math.Max(steal, skip);
    }
}