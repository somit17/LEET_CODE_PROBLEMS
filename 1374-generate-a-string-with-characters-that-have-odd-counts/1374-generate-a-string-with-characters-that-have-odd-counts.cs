public class Solution {
    public string GenerateTheString(int n) {
        return n % 2 == 1 ? new string('a', n) : new string('a', n - 1) + 'b';
    }
}