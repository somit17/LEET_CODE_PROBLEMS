public class Solution {
    public int FindMaxK(int[] nums) {
         HashSet<int> hashSet = new();
        int ans = -1;
        foreach (var num in nums)
        {
            hashSet.Add(num);
        }

        foreach (var each in nums)
        {
            if (hashSet.Contains(-each))
            {
                ans = Math.Max(ans, -each);
            }
        }

        return ans;
    }
}