public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
Dictionary<int, int> map = new();
        foreach (var eachNum in nums)
        {
            if (map.ContainsKey(eachNum))
            {
                map.TryGetValue(eachNum, out int val);
                map[eachNum] = val + 1;
            }

            else
            {
                map.Add(eachNum,1);
            }
        }

        var returnList = new List<int>();
        var pq = new PriorityQueue<int, int>();
        foreach (var keyValue in map)
        {
            pq.Enqueue(keyValue.Key, map[keyValue.Key]);
            if (pq.Count > k) pq.Dequeue();
        }

        while (k != 0)
        {
            returnList.Add(pq.Dequeue());
            k--;
        }
        return returnList.ToArray();
    }
}