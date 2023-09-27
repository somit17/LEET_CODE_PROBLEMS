public class Solution {
    public void MoveZeroes(int[] nums) {
                List<int> tempArray = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0) tempArray.Add(nums[i]);
        }

        for (int i = 0; i < tempArray.Count(); i++)
        {
            nums[i] = tempArray[i];
        }

        for (int i = tempArray.Count; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

    }
}