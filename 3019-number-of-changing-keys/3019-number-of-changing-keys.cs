public class Solution {
    public int CountKeyChanges(string s) {
       if(s.Length == 1){
            return 0;
        }
        var rs = 0;
        for(var i = 1; i < s.Length; i++){
            if(s[i] == s[i - 1] || 
                s[i].ToString().Equals(s[i - 1].ToString(), StringComparison.OrdinalIgnoreCase)){
                    continue;
                }
            else
                rs++;
        }
        return rs; 
    }
}