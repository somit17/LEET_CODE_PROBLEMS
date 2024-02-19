public class Solution {
    public string LongestCommonPrefix(string[] strs) {
          System.Array.Sort(strs);
        string first = strs[0];
        string last = strs[strs.Length - 1];

        StringBuilder ans = new StringBuilder();
        for (int i = 0; i < Math.Min(first.Length,last.Length); i++)
        {
            if (first[i] != last[i])
            {
                return ans.ToString();
            }
            else
            {
                ans.Append(first[i]);
            }
        }

        return ans.ToString();
    }
}