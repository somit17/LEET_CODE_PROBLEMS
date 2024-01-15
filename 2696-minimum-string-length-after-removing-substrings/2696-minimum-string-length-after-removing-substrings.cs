public class Solution {
    public int MinLength(string s) {
        Stack<char> stack = new();
        stack.Push('#');
        for (int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);
            if (stack.Peek() == 'B')
            {
                stack.Pop();
                if (stack.Peek() == 'A')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push('B');
                }
            }
            if (stack.Peek() == 'D')
            {
                stack.Pop();
                if (stack.Peek() == 'C')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push('D');
                }
            }
        }

       
        return  stack.Count - 1;
    }
}