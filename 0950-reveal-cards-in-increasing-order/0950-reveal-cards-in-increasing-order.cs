public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
     System.Array.Sort(deck);
        int n = deck.Length;
        int[] res = new int[deck.Length];
        System.Array.Fill(res, 0);
        bool skip = false;
        int i = 0, j = 0;

        while (i < deck.Length)
        {
            if (res[j] == 0)
            {
                if (!skip)
                {
                    res[j] = deck[i];
                    i++;
                }

                skip = !skip;
            }

            j = (j + 1) % n;
        }

        return res;   
    }
}