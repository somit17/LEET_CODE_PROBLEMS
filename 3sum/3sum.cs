public class Solution {
    IList<IList<int>> triplets = new List<IList<int>>();
    public IList<IList<int>> ThreeSum(int[] nums) {
        int n = nums.Length;
        if(n<3){
            return triplets;
        }
        Array.Sort(nums);
        for(int i=0;i<n;i++){
            if(i>0 && nums[i]==nums[i-1])
                continue;
            int target=-nums[i];
            TwoSum(nums,target,i+1,n-1);
        }
        return triplets;
    }
    void TwoSum(int[] nums,int target,int i,int j){
        while(i<j){
            int sum=nums[i]+nums[j];
            if(sum==target){
                triplets.Add(new List<int>{-target,nums[i],nums[j]});
                i++;
                j--;
                //skip duplicates
                while(i<j && nums[i]==nums[i-1]) i++;
                while(i<j && nums[j]==nums[j+1]) j--;
            }else if(sum<target){
                i++;
            }else{
                j--;
            }
        }
    }
}