public class Solution {
    public string DestCity(IList<IList<string>> paths) {
       Dictionary<string, string> hashMap = new();
        foreach (var path in paths)
        {
            hashMap.Add(path[0], path[1]);
        }

        string key = hashMap.FirstOrDefault().Key;
        while (hashMap.ContainsKey(key))
        {
            string destination;
            hashMap.TryGetValue(key, out destination);
            key = destination;
        }

        return key; 
    }
}