public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var hashMap = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int diff = target-nums[i];
            if(hashMap.ContainsKey(diff)){
                return new[] {i,hashMap[diff]};
            }
            hashMap[nums[i]]=i;
        }
        return new int[]{-1,-1};
    }
    
}