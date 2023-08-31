public class Solution {
    public int[] Shuffle(int[] nums, int n) {
       List<int> returnArray = new();
        List<int> leftArray = new();
        List<int> rightArray = new();
        int mid = n - 1;
        for(int i = 0; i <= mid; i++)
        {
            leftArray.Add(nums[i]);
        }
        for (int i = mid+1; i < nums.Length; i++)
        {
            rightArray.Add(nums[i]);
        }
        for (int i = 0; i <= mid; i++)
        {
            returnArray.Add(leftArray[i]);
            returnArray.Add(rightArray[i]);
        }
        return returnArray.ToArray(); 
    }
}