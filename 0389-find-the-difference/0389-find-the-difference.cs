public class Solution {
    public char FindTheDifference(string s, string t) {
      Dictionary<char, int> mapS = new(); //map char:int
        Dictionary<char, int> mapT = new();
        foreach (var eachChar in s)
        {
            if (mapS.ContainsKey(eachChar))
            {
                mapS.TryGetValue(eachChar, out int val);
                mapS[eachChar] = val + 1;
            }
            else
            {
                mapS.Add(eachChar, 1);
            }
        }

        foreach (var eachChar in t)
        {
            if (mapT.ContainsKey(eachChar))
            {
                mapT.TryGetValue(eachChar, out int val);
                mapT[eachChar] = val + 1;
            }
            else
            {
                mapT.Add(eachChar, 1);
            }
        }

        foreach (var chars in t)
        {
            if (mapS.ContainsKey(chars))
            {
                if (mapT[chars] != mapS[chars])
                    return chars;
            }
            else
                return chars;
        }

        return ' ';
    }
}