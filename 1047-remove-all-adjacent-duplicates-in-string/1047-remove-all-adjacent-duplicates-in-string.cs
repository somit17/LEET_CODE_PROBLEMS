public class Solution {
    public string RemoveDuplicates(string s) {
     Stack<char> stack = new();
        foreach (char c in s)
        {
            if(stack.Any() && stack.Peek() == c)
                stack.Pop();
            else
                stack.Push(c);
        }

        return string.Join("", stack.Reverse());   
    }
}