public class Solution {
    public void ReverseString(char[] s) {
        int left=0,right=s.Length-1;
        while(right>left){
            char tempChar = s[left];
            s[left]=s[right];
            s[right]=tempChar;
            right--;
            left++;
        }
    }
}