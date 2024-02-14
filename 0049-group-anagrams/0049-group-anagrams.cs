public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
         var groups = new Dictionary<string, IList<string>>();
        foreach (var eachString in strs)
        {
            char[] hash = new char[26];
            foreach (var eachChar in eachString)
            {
                hash[eachChar - 'a']++;
            }
            string key = new string(hash);
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(eachString);
        }

        return groups.Values.ToList();
    }
}