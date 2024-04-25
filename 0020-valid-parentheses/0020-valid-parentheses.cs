public class Solution {
    public bool IsValid(string s) {
       Dictionary<char, char> map = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };
        Stack<char> stack = new();
        //"]]"
        foreach (char paranthesis in s)
        {
            if (map.ContainsKey(paranthesis))
            {
                stack.Push(map[paranthesis]);
            }
            else if (stack.Count == 0 || stack.Pop() != paranthesis)
                return false;
        }

        return stack.Count == 0;
    }
}