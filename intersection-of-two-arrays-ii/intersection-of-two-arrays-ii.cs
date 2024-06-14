public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var hashMap =new Dictionary<int,int>(); //map : number:count
        foreach(var num in nums1){
            if(!hashMap.ContainsKey(num))
                hashMap[num]=1;
            else hashMap[num]++;
        }
        List<int> result = new List<int>();
        foreach(var num in nums2){
            if(hashMap.ContainsKey(num) && hashMap[num]>0){
                result.Add(num);
                hashMap[num]--;
            }
        }
        return result.ToArray();
    }
}