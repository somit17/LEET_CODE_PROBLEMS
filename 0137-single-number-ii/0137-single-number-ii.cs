public class Solution {
    public int SingleNumber(int[] nums) {
        var dic=new Dictionary<int,int>();//map no:count
        foreach(var num in nums){
            if(!dic.ContainsKey(num)) dic[num]=1;
            else dic[num]++;
        }
        foreach(var data in dic){
            if(data.Value==1)
                return data.Key;
        }
        return 0;
    }
}