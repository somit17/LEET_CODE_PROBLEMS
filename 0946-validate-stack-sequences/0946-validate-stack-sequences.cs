public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
         int len = pushed.Length;
        Stack<int> stack = new();
        int i = 0, j = 0;
        while (i < len && j < len)
        {
            stack.Push(pushed[i]);
            while (stack.Count > 0 && stack.Peek() == popped[j])
            {
                stack.Pop();
                j++;
            }

            i++;
        }

        return stack.Count == 0;
    }
}