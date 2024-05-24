public class Solution {
    public int[] CountBits(int n) {
        int[] counting=new int[n+1];
        for(int i=0;i<=n;i++){
            var numInString=Convert.ToString(i,2);
            int count=0;
            foreach(char ch in numInString){
                if(ch=='1')
                    count++;    
            }
            counting[i]=count;
        }
        return counting;
    }
}