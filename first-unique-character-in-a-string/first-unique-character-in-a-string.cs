public class Solution {
    
    public int FirstUniqChar(string s) {
        var map = new Dictionary<char,int>();
        foreach(var eachChar in s)
        {
            if(map.ContainsKey(eachChar))
                map[eachChar]++;            
            else
                map[eachChar]=1;
        }
        for(int i=0;i<s.Length;i++){
            if(map[s[i]]==1)
                return i;
        }
        return -1;
    }
}