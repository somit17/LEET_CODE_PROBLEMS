public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int, int> hashMap = new();
        foreach (var eachNum in nums)
        {
            if (hashMap.ContainsKey(eachNum))
            {
                int val;
                hashMap.TryGetValue(eachNum, out val);
                hashMap[eachNum] = val + 1;
            }
            else
            {
                hashMap.Add(eachNum, 1);
            }
        }

        foreach (var data in hashMap)
        {
            if ((data.Value & 1) == 1)
            {
                return false;
            }
        }

        return true;
    }
}