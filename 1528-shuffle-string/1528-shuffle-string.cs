public class Solution {
    public string RestoreString(string s, int[] indices) {
               Dictionary<int, char> lst = new();
        int i = 0;
        foreach (var index in indices)
        {
            lst.Add(index,s[i]);
            i++;
        }

        i = 0;
        List<char> ret = new List<char>();
        foreach (var index in indices)
        {
           var a =  lst[i];
            ret.Add(a);
            i++;
        }
string returnString = string.Concat(ret);

        return returnString;
    }
}