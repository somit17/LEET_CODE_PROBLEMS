public class Solution {
    public string MaximumOddBinaryNumber(string s) {
      int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1')
            {
                count++;
            }
        }

        List<char> finalString = new List<char>(string.Concat(Enumerable.Repeat(0,s.Length)));
        if (count>0)
        {
            finalString[s.Length-1] = '1';
            count--;
        }

        int index = 0;
        while (count>0)
        {
            finalString[index] = '1';
            count--;
            index++;
        }
        return new string(finalString.ToArray());  
    }
}