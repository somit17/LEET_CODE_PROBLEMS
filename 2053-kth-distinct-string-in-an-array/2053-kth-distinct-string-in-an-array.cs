public class Solution {
    public string KthDistinct(string[] arr, int k) {
       Dictionary<string, int> hashMap = new();
        foreach (var eachString in arr)
        {
            if (hashMap.ContainsKey(eachString))
            {
                int val;
                hashMap.TryGetValue(eachString, out val);
                hashMap[eachString] = val + 1;
            }
            else
            {
                hashMap.Add(eachString, 1);
            }
        }

        var distinctList = hashMap.Where(x => x.Value == 1).ToList();
        string result = distinctList.Count >0 && distinctList.Count>= k - 1 ? distinctList.ElementAt(k - 1).Key : string.Empty;
        
        

        return result;
    }
}