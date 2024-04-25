public class Solution {
    public string RemoveStars(string s) {
      Stack<char> stack = new();
        foreach (char eachChar in s)
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

        return string.Join("", stack.Reverse());  
    }
}