public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> numsStack = new Stack<int>();
        foreach (var operand in operations)
        {
            int num = 0;
            if (int.TryParse(operand, out num))
            {
                numsStack.Push(num);
            }
            else
            {
                switch (operand)
                {
                    case "C":
                        numsStack.Pop();
                        
                        break;
                    case "D":
                        numsStack.Push(numsStack.Peek()*2);
                        break;
                    case "+":
                        int num1 = numsStack.Any() ? numsStack.Pop() : 0;
                        int num2 = numsStack.Any() ? numsStack.Peek() : 0;
                        numsStack.Push(num1);
                        numsStack.Push(num1 + num2);

                        break;
                    default: break;
                }
            }
        }

        int sum = 0;
        while (numsStack.Any())
        {
            sum += numsStack.Pop();
        }

        return sum;
    }
}