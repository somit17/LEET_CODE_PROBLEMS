public class Solution {
    public int FindDuplicate(int[] nums) {
      Dictionary<int, int> hashSet = new();//Map number:Count
        foreach (var eachNum in nums)
        {
            if (hashSet.ContainsKey(eachNum))
            {
                return eachNum;
            }
            else
            {
                hashSet.Add(eachNum,0);
            }
        }

        return hashSet.FirstOrDefault(x => x.Value != 0).Key;  
    }
}