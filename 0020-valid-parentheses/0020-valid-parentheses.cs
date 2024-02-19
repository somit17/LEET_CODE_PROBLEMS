public class Solution {
    public bool IsValid(string s) {
       var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>()
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        foreach (var eachChar in s)
        {
            if (!pairs.ContainsKey(eachChar))
            {
                stack.Push(eachChar);
            }
            else if (stack.Count == 0 || stack.Pop() != pairs[eachChar])
            {
                return false;
            }
        }

        return stack.Count == 0;  
    }
}