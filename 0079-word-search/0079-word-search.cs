public class Solution {
    private List<List<int>> directions = new List<List<int>>()
    {
        new List<int>() { 1, 0 },
        new List<int>() { -1, 0 },
        new List<int>() { 0, 1 },
        new List<int>() { 0, -1 },
    };

    int m, n;

    public bool Exist(char[][] board, string word)
    {
        m = board.Length;
        n = board[0].Length;
        // Traverse
        for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            if (board[i][j] == word[0] && Find(board, i, j, 0, word))
                return true;
        return false;
    }

    private bool Find(char[][] board, int i, int j, int idx, string word)
    {
        if (idx == word.Length)
            return true;
        if (i < 0 || j < 0 || i >= m || j >= n || board[i][j] == '$')
            return false;
        if (board[i][j] != word[idx])
            return false;
        char temp = board[i][j];
        board[i][j] = '$';
        foreach (var dir in directions)
        {
            int newI = i + dir[0], newJ = j + dir[1];
            if (Find(board, newI, newJ, idx + 1, word))
                return true;
        }

        board[i][j] = temp;
        return false;
    }
}