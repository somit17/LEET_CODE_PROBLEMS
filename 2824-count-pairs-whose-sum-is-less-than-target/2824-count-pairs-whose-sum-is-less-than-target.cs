public class Solution {
    public int CountPairs(IList<int> nums, int target) {
        int count = 0;
        for(int i =0; i< nums.Count; i++){
            for(int j = i+1; j<nums.Count; j++){
                int sum = nums[i] + nums[j];
                if(sum < target){
                    count++;
                }
            }
        }
        return count;
    }
}