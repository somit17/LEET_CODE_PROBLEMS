public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> ST = new();
        Dictionary<char, char> TS = new();

        for (int i = 0; i < s.Length; i++)
        {
            //ST
            if (ST.ContainsKey(s[i]))
            {
                if (ST[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                ST.Add(s[i],t[i]);
            }
            
            //TS
            if (TS.ContainsKey(t[i]))
            {
                if (TS[t[i]] != s[i])
                {
                    return false;
                }
            }
            else
            {
                TS.Add(t[i],s[i]);
            }
        }

        return true;
        
    }
}