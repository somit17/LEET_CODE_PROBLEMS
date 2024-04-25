public class Solution {
    public char FindTheDifference(string s, string t) {
      int s_Sum = 0, t_Sum = 0;
        foreach (var item in s)
        {
            s_Sum += item;
        }
        foreach (var item in t)
        {
            t_Sum += item;
        }

        return (char) (t_Sum - s_Sum);
    }
}