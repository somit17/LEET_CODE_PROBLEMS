public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        Array.Sort(nums);
        foreach(var num in nums){
            if(num==original){
                original=original*2;
            }
        }
        return original;
    }
}