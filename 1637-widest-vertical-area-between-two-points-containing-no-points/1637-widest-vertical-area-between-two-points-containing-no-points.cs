public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        var arr = new int[points.GetLength(0)];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = points[i][0];
        }

        Array.Sort(arr);

        var result = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            result = Math.Max(result, arr[i] - arr[i - 1]);
        }

        return result;
    }
}