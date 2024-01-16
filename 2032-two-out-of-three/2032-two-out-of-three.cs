public class Solution {
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3) {
        Dictionary<int, string> hashMap = new();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!hashMap.ContainsKey(nums1[i]))
            {
                hashMap.Add(nums1[i],"A");
            }
            
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (!hashMap.ContainsKey(nums2[i]))
            {
                hashMap.Add(nums2[i],"B");
            }
            else 
            {
                string val;
                hashMap.TryGetValue(nums2[i],out val);
                if(!val.Equals("B")){hashMap[nums2[i]] = val+"B";}
            }
            
        }
        for (int i = 0; i < nums3.Length; i++)
        {
            if (!hashMap.ContainsKey(nums3[i]))
            {
                hashMap.Add(nums3[i],"C");
            }
            else
            {
                string val;
                hashMap.TryGetValue(nums3[i],out val);
                if(!val.Equals("C")){hashMap[nums3[i]] = val+"C";}
               
            }
            
        }

        return hashMap.Where(s => s.Value.Length >= 2).Select(x=>x.Key).ToList();
    }
}