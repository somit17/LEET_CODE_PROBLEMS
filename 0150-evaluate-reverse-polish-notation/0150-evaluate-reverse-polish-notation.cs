public class Solution {
    int evaluateResult(int a, int b, string op) => op switch
    {
        "+" => a + b,
        "-" => b-a,
        "*" => a * b,
        "/" => b/a,
        _ => throw new Exception()
    };

    public int EvalRPN(string[] tokens)
    {
        int res = 0;
        Stack<int> stack = new();
        foreach (string eachOperand in tokens)
        {
            bool isNum = int.TryParse(eachOperand, out int number);
            if (isNum)
            {
                stack.Push(number);
            }
            else
            {
                res = evaluateResult(stack.Pop() , stack.Pop() , eachOperand);
                stack.Push(res);
            }
        }

        return stack.Pop();
    }
}