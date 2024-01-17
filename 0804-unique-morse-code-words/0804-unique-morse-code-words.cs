public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        List<string> strings = new List<string>()
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
            ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };
        Dictionary<char, string> hashTable = new()
        {
        };
        char c = 'a';
        foreach (var eachString in strings)
        {
            hashTable.Add(c, eachString);
            c++;
        }

        Dictionary<string, int> hashMap = new();
        foreach (var eachWord in words)
        {
            string pattern = string.Empty;
            foreach (var eachChar in eachWord)
            {
                string val;
                hashTable.TryGetValue(eachChar, out val);
                pattern += val;
            }
            if (!hashMap.ContainsKey(pattern))
            {
                hashMap.Add(pattern, 1);
            }
        }


        return hashMap.Count;
    }
}