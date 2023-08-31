public class Solution {
    public int[] RunningSum(int[] nums) {
       List<int> returnArray
             = new();
        int prev = 0,sum=0;
        foreach(var num in nums)
        {
            sum = num + prev;
            returnArray.Add(sum);
            prev = sum;
        }
        return returnArray.ToArray();
    }
}