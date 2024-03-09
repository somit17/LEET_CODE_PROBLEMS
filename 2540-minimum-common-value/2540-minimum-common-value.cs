public class Solution {
    public int GetCommon(int[] nums1, int[] nums2) {
        HashSet<int> hashSet1 = new HashSet<int>(nums1);
        HashSet<int> hashSet2 = new HashSet<int>(nums2);
        foreach (var element in hashSet1)
        {
            if (hashSet2.Contains(element))
            {
                return element;
            }
        }

        return -1;
    }
}