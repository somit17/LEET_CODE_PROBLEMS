public class Solution {
    public IList<int> FindPeaks(int[] mountain) {
        IList<int> returnList = new List<int>();
        for (int i=1;i<=mountain.Length-2;i++){
            int current=mountain[i];
            int prev=mountain[i-1];
            int next = mountain[i+1];
            if(current>prev && current>next){
                returnList.Add(i);
            }
        }
        return returnList;
    }
}