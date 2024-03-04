public class Solution {
    public bool WordPattern(string pattern, string s) {
     
      Dictionary<string, char> hashMap = new();
        var splitString = s.Split(' ');
        if (splitString.Length != pattern.Length) return false;
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!string.IsNullOrEmpty(splitString[i]))
            {
                if (!hashMap.ContainsKey(splitString[i])&& !hashMap.ContainsValue(pattern[i]))
                {
                    hashMap.Add(splitString[i], pattern[i]);
                }
            }
        }

        StringBuilder finalPatter = new StringBuilder();
        foreach (var eachPatternChar in splitString)
        {
            if (!string.IsNullOrEmpty(eachPatternChar))
            {
                hashMap.TryGetValue(eachPatternChar, out char value);
                finalPatter.Append(value);
            }
        }

        //
        // //var a = String.Concat(s.Where(x => !Char.IsWhiteSpace(x)));
        return finalPatter.ToString().Equals(pattern);
    
    }
    
}