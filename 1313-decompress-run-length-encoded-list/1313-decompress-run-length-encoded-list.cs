public class Solution {
    public int[] DecompressRLElist(int[] nums) {
        List<int> decomprresedList = new();
        for (int i = 0; i < nums.Length; i+=2)
        {
            int freq = nums[i];
            int val = nums[i + 1];
            decomprresedList.AddRange(Enumerable.Repeat(val, freq));
        }

        return decomprresedList.ToArray();
    }
}