public class Solution {
    public string FinalString(string s) {
       StringBuilder finalString = new StringBuilder();
        foreach (var eachChar in s)
        {
            if (eachChar.Equals('i'))
            {
               var reverseString  =  new string( finalString.ToString().Reverse().ToArray());
               finalString = new StringBuilder(reverseString);
            }
            else
            {
                finalString.Append(eachChar);
            }
        }

        return finalString.ToString();
    }
}