public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums == null || nums.Length == 0)
            return 0;
        int slowIndex=0,fastIndex=0;
        
        while(slowIndex<nums.Length && fastIndex<nums.Length){
            if(nums[fastIndex]!=val){
                nums[slowIndex]=nums[fastIndex];
                slowIndex++;
                fastIndex++;
            }else{
                fastIndex++;
            }
        }
        
        return slowIndex;
    }
}