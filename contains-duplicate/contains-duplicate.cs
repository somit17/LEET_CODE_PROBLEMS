public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        //brute-force
        var dic =new Dictionary<int,int>();
        foreach(var num in nums){
            if(!dic.ContainsKey(num))
                dic[num]=1;
            else dic[num]++;
            if(dic[num]==2)
                return true;
        }
        return false;
        
    }
}