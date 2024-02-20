public class Solution {
    public int DivisorSubstrings(int num, int k) {
        string data = num.ToString();
        int count = 0;
        string x = "";
        for(int i = 0 ; i < k; i++) {
            x += data[i];
        }
        if(num % Int32.Parse(x) == 0) count += 1;
        for(int i = k ; i < data.Length; i++) {
            x += data[i];
            x = x.Substring(1);
            if(Int32.Parse(x) != 0 && num % Int32.Parse(x) == 0) count += 1;
        }

        return count;
    }
}