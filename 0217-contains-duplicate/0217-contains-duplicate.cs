public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hashSet = new();
        foreach (var eachNum in nums)
        {
            if (hashSet.Contains(eachNum))
            {
                return true;
            }
            hashSet.Add(eachNum);
        }

        return false;
    }
}