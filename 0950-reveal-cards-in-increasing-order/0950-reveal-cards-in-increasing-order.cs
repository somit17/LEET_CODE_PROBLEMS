public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {
     System.Array.Sort(deck);
        int n = deck.Length;
        int[] res = new int[deck.Length];
        System.Array.Fill(res, 0);
        Queue<int> queue = new();
        for (int i = 0; i < n; i++)
            queue.Enqueue(i);

        for (int i = 0; i < n; i++)
        {
            int idx = queue.Peek();
            queue.Dequeue();
            res[idx] = deck[i];
            if (queue.Count>0)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }
        return res;
    }
}