public class Solution {
    public int MaxNumberOfBalloons(string text) {
       Dictionary<char, int> hashMap = new();
        Dictionary<char, int> required = new()
        {
            { 'b', 1 }, { 'a', 1 }, { 'l', 2 }, { 'o', 2 }, { 'n', 1 }
        };

        var ballonsChar = new char[] { 'b', 'a', 'l', 'o', 'n' };
        foreach (var eachChar in text)
        {
            if (ballonsChar.Contains(eachChar))
            {
                if (hashMap.ContainsKey(eachChar))
                {
                    hashMap.TryGetValue(eachChar, out int value);
                    hashMap[eachChar] = value + 1;
                }
                else
                {
                    hashMap.Add(eachChar, 1);
                }
            }
        }
        int result = text.Length;
        foreach (var balloonCount in required) {
            if (hashMap.ContainsKey(balloonCount.Key)) {
                result = Math.Min(result, hashMap[balloonCount.Key] / balloonCount.Value);
            } else {
                result = 0;
                break;
            }
        }
        return result; 
    }
}