public class Solution {
   public int NumTilePossibilities(string tiles) {
        int[] count = new int[26];
        foreach (char c in tiles)
            count[c - 'A']++;
        return CountSequences(count);
    }

    private int CountSequences(int[] count) {
        int total = 0;
        for (int i = 0; i < 26; i++) {
            if (count[i] == 0) continue; // Skip if the letter count is zero

            total++; // Count the sequence with the current letter

            count[i]--; // Use one occurrence of the current letter
            total += CountSequences(count); // Recursively count sequences with reduced count
            count[i]++; // Restore the count for backtracking
        }
        return total;
    }
}