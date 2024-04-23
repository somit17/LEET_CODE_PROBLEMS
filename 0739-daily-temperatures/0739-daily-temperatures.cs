public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
     Stack<(int, int)> stack = new(); //Temp:Days
        int[] res = new int[temperatures.Length];
        System.Array.Fill(res, 0);
            
             
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Any() && temperatures[i] > stack.Peek().Item1)
            {
                var (stackT, stackInd) = stack.Pop();
                res[stackInd] = (i - stackInd);
            }
            stack.Push((temperatures[i], i));
        }

        return res;   
    }
}