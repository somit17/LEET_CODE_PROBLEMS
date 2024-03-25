public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        List<int> duplicates = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1; // Adjust index to 0-based
            if (nums[index] < 0)
            {
                duplicates.Add(Math.Abs(nums[i])); // Add the duplicate number
            }
            else
            {
                nums[index] = -nums[index]; // Negate the number to mark its presence
            }
        }
        return duplicates;
    }
}