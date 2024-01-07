public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
         List<int> returnArray = new()
        {
            0,0
        };
        ;
        Dictionary<int, int> hashMap1 = new();Dictionary<int, int> hashMap2 = new();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (hashMap1.ContainsKey(nums1[i]))
            {
                int val = 0;
                hashMap1.TryGetValue(nums1[i], out val);
                hashMap1[nums1[i]] = val + 1;
            }
            else
            {
                hashMap1.Add(nums1[i],1);
            }
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (hashMap2.ContainsKey(nums2[i]))
            {
                int val = 0;
                hashMap2.TryGetValue(nums2[i], out val);
                hashMap2[nums2[i]] = val + 1;
            }
            else
            {
                hashMap2.Add(nums2[i],1);
            }
        }

        foreach (var val in hashMap1.Keys)
        {
            if (hashMap2.ContainsKey(val))
            {
                int value = 0;
                hashMap1.TryGetValue(val, out value);
                returnArray[0] += value;
            }
        }
        foreach (var val in hashMap2.Keys)
        {
            if (hashMap1.ContainsKey(val))
            {
                int value = 0;
                hashMap2.TryGetValue(val, out value);
                returnArray[1] += value;
            }
        }
        return returnArray.ToArray();
    }
}