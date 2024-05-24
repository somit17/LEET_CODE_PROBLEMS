public class Solution {
    int[] mem=new int[46];
    public int ClimbStairs(int n) {
        Array.Fill(mem,-1);
        return solve(n);
      }
    int solve(int n){
        if(n<0) return 0;
        if(mem[n]!=-1){
            return mem[n];
        }
        if(n==0) return 1;
        int oneStep=solve(n-1);
        int twoStep=solve(n-2);
        return  mem[n]=oneStep+twoStep;
    }
}