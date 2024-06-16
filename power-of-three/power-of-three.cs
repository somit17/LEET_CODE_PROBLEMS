public class Solution {
    public bool IsPowerOfThree(int n) {
        if (n <= 0) return false;

        double logResult = Math.Log(n) / Math.Log(3);
        return Math.Abs(logResult - Math.Round(logResult)) < 1e-10;
    }
}