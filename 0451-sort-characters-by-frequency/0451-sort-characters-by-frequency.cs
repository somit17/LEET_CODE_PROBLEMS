public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int> hashMap = new(); //map char :: count
        foreach (char c in s)
        {
            if (!hashMap.ContainsKey(c))
                hashMap.Add(c, 1);
            else
                hashMap[c]++;
        }

        var frqHash = hashMap.OrderByDescending(x => x.Value);
        string finalans = "";
        foreach (var data in frqHash)
        {
            finalans += string.Join("",Enumerable.Repeat(data.Key, data.Value));
        }

        return finalans;
    }
}