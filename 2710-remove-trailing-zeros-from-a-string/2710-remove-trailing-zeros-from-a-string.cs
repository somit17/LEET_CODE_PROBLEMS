public class Solution {
    public string RemoveTrailingZeros(string num) {
        
StringBuilder returnString = new StringBuilder(num);
        while (returnString.ToString().EndsWith('0'))
        {
            returnString=  returnString.Remove(returnString.Length-1,1);
        }
        return returnString.ToString();
    }
}