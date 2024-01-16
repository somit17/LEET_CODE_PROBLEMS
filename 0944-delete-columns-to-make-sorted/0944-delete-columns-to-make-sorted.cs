public class Solution {
    public int MinDeletionSize(string[] strs) {
        int count = 0;
        for (int  c = 0; c < strs[0].Length; c++) {
            for (int  i = 0; i < strs.Length - 1; i++) {
                if (strs[i].ElementAt(c) > strs[i + 1].ElementAt(c)) {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}