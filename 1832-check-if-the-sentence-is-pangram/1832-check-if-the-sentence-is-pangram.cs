public class Solution {
    public bool CheckIfPangram(string sentence) {
        Dictionary<char, char> hashMap = new();
        char c = 'a';
        foreach (var eachChar in sentence)
        {
            if (!hashMap.ContainsKey(eachChar))
            {
                hashMap.Add(eachChar, eachChar);
                c++;
            }
        }

        if (hashMap.Count == 26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}