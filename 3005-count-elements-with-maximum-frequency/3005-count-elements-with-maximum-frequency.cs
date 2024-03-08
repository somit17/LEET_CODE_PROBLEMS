public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> hashMap = new(); //Map num:count
        foreach (var num in nums)
        {
            if (hashMap.ContainsKey(num))
            {
                hashMap.TryGetValue(num, out int val);
                hashMap[num] = val+1;
            }
            else
            {
                hashMap.Add(num,1);
            }
        }
        
        int maxFreq = hashMap.Values.OrderByDescending(x=>x).FirstOrDefault();
        return hashMap.Values.Where(x=>x==maxFreq).Sum();
    }
}