public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char> hashMap = new();
        char append = 'a';
        foreach (var c in key)
        {
            if (c != ' ')
            {
                if (!hashMap.ContainsKey(c))
                {
                    hashMap.Add(c, append);
                    append++;
                }
            }
        }

        List<char> decodedMessage= new List<char>();
        foreach (var m in message)
        {
            char val;
            if (m == ' ')
            {
                decodedMessage.Add(m);
            }
            else
            {
                hashMap.TryGetValue(m, out val);
                decodedMessage.Add(val);
            }
        }
        
        return new string(decodedMessage.ToArray());
    }
}