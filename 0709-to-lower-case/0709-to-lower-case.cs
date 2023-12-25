public class Solution {
    public string ToLowerCase(string s) {
        StringBuilder finalString = new();
        foreach (var c in s)
        {
            if (Char.IsUpper(c))
            {
                finalString.Append(Char.ToLower(c));
            }
            else
            {
                finalString.Append(c);
            }
        }

        return finalString.ToString();
    }
}