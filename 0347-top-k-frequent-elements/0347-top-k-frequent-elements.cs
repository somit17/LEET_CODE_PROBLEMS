public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
                Dictionary<int, int> hashMap = new Dictionary<int, int>(); // map num:count
        foreach (int num in nums)
        {
            if (!hashMap.ContainsKey(num))
                hashMap.Add(num, 1);
            else
                hashMap[num]++;
        }

        return hashMap.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

    }
}