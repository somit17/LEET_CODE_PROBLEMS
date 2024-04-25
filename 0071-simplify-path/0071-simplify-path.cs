public class Solution {
    public string SimplifyPath(string path) {
        string[] tokens = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        Stack<string> stack = new();
        foreach (var eachPath in tokens)
        {
            if(eachPath==".") continue;
            if (eachPath != "..")
                stack.Push(eachPath);
            else
            {
                if (stack.Count > 0) stack.Pop();
            }
        }

        if (stack.Count == 0) return "/";
        string res = string.Empty;
        while (stack.Count > 0)
            res = "/" + stack.Pop() + res;
        return res;
    }
}