public class Solution {
    public int ScoreOfString(string s) {
        var rs = 0;
        for(var i = 1; i < s.Length; i++){
            rs += Math.Abs(s[i - 1] - s[i]);
        } 
        return rs;
    }
}