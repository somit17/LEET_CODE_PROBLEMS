public class Solution {
    public int[] LeftRightDifference(int[] nums) {
        List<int> leftArray = new();
        List<int> tempRightArray = new();
        List<int> rightArray = new();
        List<int> returnArray = new();
        int prevNUm = 0;
        foreach (var num in nums)
        {
            leftArray.Add(prevNUm);
            prevNUm += num;
        }
        prevNUm = 0;
        for (int i = nums.Length-1; i >= 0; i--)
        {
            tempRightArray.Add(prevNUm);
            prevNUm += nums[i];
        }

        for (int i = nums.Length-1; i >= 0; i--)
        {
            rightArray.Add(tempRightArray[i]);
        }
        
        for (int i =0; i <=nums.Length-1 ; i++)
        {
            int value = Math.Abs(leftArray[i]) - Math.Abs(rightArray[i]);
                       returnArray.Add(Math.Abs(value));
        }

        return returnArray.ToArray();
    }
}