public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
int counter = 0;

        #region Brute Force

        // for (int i = 0; i < jewels.Length; i++)
        // {
        //     for (int j = 0; j < stones.Length; j++)
        //     {
        //         if (jewels[i] == stones[j]) counter++;
        //     }
        // }

        #endregion

        #region Optimal


        Dictionary<char, int> jewelsHash = new();
        //List<char> stonesHash = new();
        for (int j = 0; j < jewels.Length; j++)
        {
            jewelsHash.Add(jewels[j],0);
        }

        for (int j = 0; j < stones.Length; j++)
        {
            if (jewelsHash.ContainsKey(stones[j]))
            {
                jewelsHash[stones[j]] += 1;
            }
        }

        //Get count of values in list
        var count =  jewelsHash.Where(x => x.Value > 0).Select(x => x.Value).Sum();

        return count;


        #endregion

        //return counter;
    }
}