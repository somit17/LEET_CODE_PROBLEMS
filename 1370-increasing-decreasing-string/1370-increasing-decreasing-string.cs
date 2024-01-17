public class Solution {
    public string SortString(string s) {
         SortedDictionary<char, int> hashTable = new();
        foreach (var eachChar in s)
        {
            if (hashTable.ContainsKey(eachChar))
            {
                int val;
                hashTable.TryGetValue(eachChar, out val);
                hashTable[eachChar] = val + 1;
            }
            else
            {
                hashTable.Add(eachChar, 1);
            }
        }

        string result = string.Empty;
        // for (int i = 0; i < hashTable.Keys.Count; i++)
        // {
        //     result += hashTable[i].Key;
        //     hashTable[keyPair.Key] = keyPair.Value - 1;
        // }
        SortedDictionary<char, int> collection2 = new SortedDictionary<char, int>(hashTable);
        int i = 0;
        while (i < s.Length - 1)
        {
            foreach (var (key, count) in collection2)
            {
                int val;
                hashTable.TryGetValue(key, out val);
                if (val != 0)
                {
                    result += key;
                    hashTable[key] = val - 1;i++;
                }

                
            }

            foreach (var (key, count) in collection2.Reverse())
            {
                int val;
                hashTable.TryGetValue(key, out val);
                if (val != 0)
                {
                    result += key;
                    hashTable[key] = val - 1; i++;
                }

               
            }
        }

        return result +new string(hashTable.Where(x => x.Value > 0).Select(x => x.Key).ToList().ToArray());   

    }
}