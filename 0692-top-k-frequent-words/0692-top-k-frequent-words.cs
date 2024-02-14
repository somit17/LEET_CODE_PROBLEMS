public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
       var returnList = new List<string>();
        var map = new Dictionary<string, int>();
        foreach (var eachString in words)
        {
            if (map.ContainsKey(eachString))
            {
                map.TryGetValue(eachString, out int val);
                map[eachString] = val + 1;
            }
            else
            {
                map.Add(eachString,1);
            }
        }

        var newMap = map.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
        returnList = newMap.Select(x => x.Key).Take(k).ToList();
        return returnList; 
    }
}