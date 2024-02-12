public class Solution {
    public int CountNegatives(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        
        int row = n-1;
        int col = 0;
        int count = 0;
        
        while(row>=0 && col<m){
            if(grid[row][col] < 0){
                row--;
                count += m - col;
            }
            else{
                col++;
            }
        }
        return count;
    }
}