public class Solution {
    
    public int ClimbStairs(int n) {
        if(n==1||n==2)
            return n;
        int a=1;
        int b=2;
        int c=3;
        for(int i=3;i<=n;i++){
            c=a+b;
            int temp_b=b;
            b=c;
            a=temp_b;
        }
        return c;
      }
    
}