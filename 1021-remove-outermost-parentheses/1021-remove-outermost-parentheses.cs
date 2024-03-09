public class Solution {
    public string RemoveOuterParentheses(string s) {
        StringBuilder result = new();
        Stack<char> stack = new();
        foreach (var eachChar in s)
        {
            if (eachChar == '(')
            {
                if (stack.Count > 0)
                {
                    result.Append(eachChar);
                }
                stack.Push(eachChar);
            }
            else
            {
                stack.Pop();
                if (stack.Count > 0)
                {
                    result.Append(eachChar);
                }
            }
        }

       return result.ToString();
    }
}