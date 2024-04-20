public class Solution {
    public int MaximumStrongPairXor(int[] nums) {
      int L = 0, R = 0;
        List<(int, int)> lst = new();
        while (R < nums.Length)
        {
            if (Math.Abs(nums[L] - nums[R]) <= Math.Min(nums[L], nums[R]))
            {
                lst.Add((nums[L], nums[R]));
            }

            R++;
            if (R == nums.Length)
            {
                L += 1;
                R = L;
            }
        }

        int maxXOR = 0;
        foreach (var strongPairs in lst)
        {
            int currentXOR = strongPairs.Item1 ^ strongPairs.Item2;
            maxXOR = Math.Max(currentXOR, maxXOR);
        }

        return maxXOR;  
    }
}