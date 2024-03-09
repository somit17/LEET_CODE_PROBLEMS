public class Solution {
    public string RemoveDuplicates(string s, int k) {
       Stack<(char, int)> stack = new Stack<(char, int)>(); //Item1: char and Item2:count of char
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Any() && stack.Peek().Item1 == s[i])
            {
                var item = stack.Pop();
                item.Item2++;
                stack.Push(item);
            }
            else
            {
                stack.Push((s[i], 1));
            }
            while(stack.Any() && stack.Peek().Item2==k){
                stack.Pop();
            }
        }


        StringBuilder final = new();
        foreach (var (symbol, counter) in stack)
        {
            final.Append(symbol, counter);
        }
        StringBuilder returnString = new();
        for (int i = final.Length-1; i >= 0; i--)
        {
            returnString.Append(final[i]);
        }

        return returnString.ToString();
    }
}