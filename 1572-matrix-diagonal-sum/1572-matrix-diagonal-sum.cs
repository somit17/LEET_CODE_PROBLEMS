public class Solution {
    public int DiagonalSum(int[][] mat) {
        int diagonalSum = 0;
        int n = mat.Length-1;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                if (i == j)
                {
                    diagonalSum += mat[i][j];
                }
                else if (i == n - j)
                {
                    diagonalSum+=mat[i][j];
                }
            }
        }

        return diagonalSum;
    }
}