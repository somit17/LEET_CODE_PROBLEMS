public class Solution {
    public string FreqAlphabets(string s) {
        Dictionary<string, char> hashMap = new();
        int counter = 1;
        for (char i = 'a'; i <= 'i'; i++)
        {
            hashMap.Add(counter.ToString(), i);
            counter++;
        }

        for (char i = 'j'; i <= 'z'; i++)
        {
            hashMap.Add(counter.ToString() + '#', i);
            counter++;
        }

        int icounter = s.Length - 1;
        string finalString = String.Empty;
        Stack<char> stack = new();
        while (icounter !=-1)
        {
            if (!s[icounter].Equals('#'))
            {
                char getChar;
                hashMap.TryGetValue(s[icounter].ToString(), out getChar);
                stack.Push( getChar);
                icounter--;
            }
            else
            {
                int j = icounter - 2;
                string number = s.Substring(j, 3);
                char getChar;
                hashMap.TryGetValue(number, out getChar);
                stack.Push( getChar);
                icounter = icounter-3;
            }
        }
        foreach (var eachChar in stack)
        {
            finalString += eachChar;
        }

        return finalString;
    }
}