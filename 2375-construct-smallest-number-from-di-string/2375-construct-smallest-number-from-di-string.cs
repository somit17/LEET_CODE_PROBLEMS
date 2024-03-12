public class Solution {
    public string SmallestNumber(string pattern) {
        StringBuilder finalString = new();
        Stack<int> stack = new();
        for (int i = 0; i <= pattern.Length; i++)
        {
            stack.Push(i + 1);
            if (i == pattern.Length || pattern[i] == 'I')
            {
                while (stack.Count > 0)
                {
                    finalString.Append(stack.Pop());
                }
            }
        }

        return finalString.ToString();
    }
}