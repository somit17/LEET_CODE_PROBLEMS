public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        Dictionary<char, int> hashMap = new();
        for (int i = 0; i < stones.Length; i++)
        {
            if (hashMap.ContainsKey(stones[i]))
            {
                int val;
                hashMap.TryGetValue(stones[i], out val);
                hashMap[stones[i]] = val + 1;
            }
            else
            {
                hashMap.Add(stones[i], 1);
            }
        }

        int counter = 0;
        for (int j = 0; j < jewels.Length; j++)
        {
            if (hashMap.ContainsKey(jewels[j]))
            {
                int val;
                hashMap.TryGetValue(jewels[j], out val);
                counter += val;
            }
        }

        return counter;
    }
}