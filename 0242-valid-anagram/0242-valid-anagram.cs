public class Solution {
    public bool IsAnagram(string s, string t) {
      if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            Dictionary<char, int> s1 = new();
            Dictionary<char, int> s2 = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s1.ContainsKey(s[i]))
                {
                    int val;
                    s1.TryGetValue(s[i], out val);
                    s1[s[i]] = val+1;
                }
                else
                {
                    s1.Add(s[i], 1);
                }

                if (s2.ContainsKey(t[i]))
                {
                    int val;
                    s2.TryGetValue(t[i], out val);
                    s2[t[i]] = val+1;
                }
                else
                {
                    s2.Add(t[i], 1);
                }
            }

            foreach (var eachKeyValue in s1)
            {
                int val = 0;
                if (s2.ContainsKey(eachKeyValue.Key))
                {
                    s2.TryGetValue(eachKeyValue.Key, out val);
                }

                if (eachKeyValue.Value != val)
                {
                    return false;
                }
            }
        }

        return true;
    }
}