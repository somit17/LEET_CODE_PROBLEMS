public class Solution {
    public int SumOfSquares(int[] nums) {
        int sumOfSquares = 0;
        int counter = 1, arrLength = nums.Length;
        foreach (var num in nums)
        {
            if ( arrLength % counter == 0)
            {
                sumOfSquares += Convert.ToInt32(Math.Pow(num, 2));
            }

            counter++;
        }

        return sumOfSquares;
    }
}