public class Solution {
    public string FrequencySort(string s) {
        var map = new Dictionary<char, int>();
        foreach (var eachChar in s)
        {
            if (map.ContainsKey(eachChar))
            {
                map.TryGetValue(eachChar, out int val);
                map[eachChar] = val + 1;
            }
            else
            {
                map.Add(eachChar,1);
            }
        }

        var newMap = map.OrderByDescending(x => x.Value).ToList();
        StringBuilder returnString = new();
        foreach (var keyValue in newMap)
        {
            returnString.Append(new string(keyValue.Key,keyValue.Value));
        }
        return returnString.ToString();
    }
}