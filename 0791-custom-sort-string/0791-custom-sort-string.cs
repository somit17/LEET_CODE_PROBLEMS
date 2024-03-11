public class Solution {
    public string CustomSortString(string order, string s) {
        StringBuilder finalString = new StringBuilder();
        StringBuilder source = new StringBuilder(s);
        foreach (var eachChar in order)
        {
            var times = source.ToString().Where(x => x == eachChar).Count();
            if (times > 0)
            {
                source.Replace(eachChar.ToString(),  String.Empty);
                finalString.Append(String.Join("",Enumerable.Repeat(eachChar,times)));
            }
            
        }

        finalString.Append(source);
        return finalString.ToString();
    }
}