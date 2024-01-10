public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int> hashMap = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (hashMap.ContainsKey(arr[i]))
            {
                int val = 0;
                hashMap.TryGetValue(arr[i], out val);
                hashMap[arr[i]] = val+1;
            }
            else
            {
                hashMap.Add(arr[i], 1);
            }
        }

        HashSet<int> distinctList = new();
        foreach (var count in hashMap.Values)
        {
            distinctList.Add(count);
        }

        if (distinctList.Count != hashMap.Values.Count)
        {
            return false;
        }

        return true; 
    }
}