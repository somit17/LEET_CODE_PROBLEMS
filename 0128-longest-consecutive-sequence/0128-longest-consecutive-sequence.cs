public class Solution {
    public int LongestConsecutive(int[] nums) {
if (nums.Length < 2) return nums.Length;
        var set = new HashSet<int>(nums);
        int longest = 0;
        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                int length = 0;
                while (set.Contains(n + length))
                {
                    length++;
                    longest = Math.Max(longest, length);
                }
                
            }
        }

        return longest;
    }
}