public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
       List<int> returnArray = new();
        Dictionary<int, int> hashMap1 = new Dictionary<int, int>();
        Dictionary<int, int> hashMap2 = new();
        foreach (var num in nums1)
        {
            if (!hashMap1.ContainsKey(num))
            {
               hashMap1.Add(num,1);
            }
            
        }
        foreach (var num in nums2)
        {
            if (!hashMap2.ContainsKey(num))
            {
                hashMap2.Add(num,1);
            }
        }

        foreach (var num in hashMap1)
        {
            if (hashMap2.ContainsKey(num.Key))
            {
                returnArray.Add(num.Key);
            }
        }
      return  returnArray.ToArray(); 
    }
}