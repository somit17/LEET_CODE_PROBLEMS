public class Solution {
    public int MaximumNumberOfStringPairs(string[] words) {
         int maxNPairs = 0;
        Dictionary<string, int> hashMap = new();
        foreach (var word in words)
        {
            var sortedString= String.Concat(word.OrderBy(c => c));
            if (hashMap.ContainsKey(sortedString))
            {
                int val = 0;
                hashMap.TryGetValue(sortedString, out val);
                hashMap[sortedString] = val + 1;
            }
            else
            {
                hashMap.Add(sortedString, 1);
            }
        }

        maxNPairs = hashMap.Where(x => x.Value == 2).Count();
        return maxNPairs;
    }
}