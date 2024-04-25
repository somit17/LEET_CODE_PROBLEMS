public class Solution {
    public int[] AsteroidCollision(int[] asteroids)
    {
         var stack = new Stack<int>();
        for (int i = 0; i < asteroids.Length; i++)
        {
            //Collison
            while (stack.Count > 0 && stack.Peek() > 0 && asteroids[i] < 0)
            {
                var sum = asteroids[i] + stack.Peek();
                if (sum < 0)
                    stack.Pop();
                else if (sum > 0) asteroids[i] = 0;
                else
                {
                    stack.Pop();
                    asteroids[i] = 0;
                }
            }
            if (asteroids[i] != 0)
                stack.Push(asteroids[i]);
        }

        int[] result = new int[stack.Count];
        int j = stack.Count > 0 ? stack.Count - 1 : 0;
        while (stack.Count > 0)
        {
            result[j] = stack.Pop();
            j--;
        }

        return result;
    }
}