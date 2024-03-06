public class Solution {
    public int MinOperations(int[] nums, int k) {
        int count=0;
       foreach(var num in nums){
           if(num<k){
               count++;
           }
       }
        return count++;
    }
}