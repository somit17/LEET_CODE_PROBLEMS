public class Solution {
    public int TimeRequiredToBuy(int[] tickets, int k) {
        int totalSec = 0, n = tickets.Length;
        while (tickets[k] >0)
        {
            for (int i = 0; i < n; i++)
            {
                if (tickets[i] != 0)
                {
                    tickets[i] -= 1;
                    totalSec += 1;
                }
                if(tickets[k]==0) break;
            }
        }
        return totalSec;
    }
}