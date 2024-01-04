public class Solution {
    public int MinMovesToSeat(int[] seats, int[] students) {
         int minMoves = 0;
        List<(int, int)> list = new();
        System.Array.Sort(seats);
        System.Array.Sort(students);
        for (int i = 0; i < seats.Length; i++)
        {
            minMoves += Math.Abs(seats[i] - students[i]);
        }

        return minMoves;
    }
}