public class Solution {
    public void MoveZeroes(int[] nums) {
        //brute force
        int count=0;
        List<int> result =new();
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0)
                result.Add(nums[i]);
            else count++;
        }
        while(count>0){
            result.Insert(result.Count,0);
            count--;
        }
        for(int i=0;i<result.Count;i++){
            nums[i]=result[i];
        }
    
    }
}