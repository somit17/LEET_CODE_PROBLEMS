public class Solution {
    public int LongestStrChain(string[] words)
    {
        int n = words.Length;
        int[][] dp = new int[n + 1][];
        for (int i = 0; i < n; i++)
        {
            dp[i] = new int[n + 1];
            for (int j = 0; j < n + 1; j++)
            {
                dp[i][j] = -1; //Initialize the array
            }
        }

        System.Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
        return Solve(words, dp, 0, -1);
    }

    public int Solve(string[] words, int[][] dp, int idx, int prev)
    {
        if (idx >= words.Length)
            return 0;
        if (prev != -1 && dp[idx][prev] != -1)
            return dp[idx][prev];
        int take = 0, skip = 0;
        if (prev == -1 || isPred(words[prev], words[idx]))
        {
            take = Solve(words, dp, idx + 1, idx) + 1;
        }

        skip = Solve(words, dp, idx + 1, prev);
        if (prev != -1) {
            dp[idx][prev] = Math.Max(skip, take);
        }
        return Math.Max(take, skip);
    }

    private bool isPred(string prev, string current)
    {
        int M = prev.Length;
        int N = current.Length;
        if (M >= N || N - M != 1)
            return false;
        if (M >= N || N - M != 1)
            return false;

        int i = 0, j = 0;
        while (i < M && j < N)
        {
            if (prev[i] == current[j])
            {
                i++;
            }

            j++;
        }

        return i == M;
    }
}