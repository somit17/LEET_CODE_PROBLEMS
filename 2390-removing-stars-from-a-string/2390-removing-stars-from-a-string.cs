public class Solution {
    public string RemoveStars(string s) {
       Stack<char> stack = new Stack<char>();
        foreach (var eachChar in s)
        {
            if (eachChar.Equals('*'))
            {
                if (stack.Count > 0) stack.Pop();
            }
            else
            {
                stack.Push(eachChar);
            }
        }

        List<char> finalOriginalString = new();
        while (stack.Count>0)
        {
            finalOriginalString.Add(stack.Pop());
        }

        StringBuilder returnString = new StringBuilder();
        for (int i = finalOriginalString.Count-1; i >=0 ; i--)
        {
            returnString.Append(finalOriginalString[i]);
        }
         
        return returnString.ToString(); 
    }
}