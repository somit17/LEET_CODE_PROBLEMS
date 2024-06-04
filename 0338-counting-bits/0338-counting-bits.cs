public class Solution {
    public int[] CountBits(int n) {
        if(n==0) return new int[]{0};
        int[] res=new int[n+1];
        res[0]=0;
        for(int i=1;i<=n;i++){
            if(i%2!=0)
                res[i]=res[i/2]+1;
            else
                res[i]=res[i/2];
        }
        return res;
    }
}