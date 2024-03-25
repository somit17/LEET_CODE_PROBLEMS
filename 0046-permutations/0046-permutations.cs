public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
       IList<IList<int>> perms = new List<IList<int>>();
        perms.Add(new List<int>());
        foreach (var n in nums)
        {
            IList<IList<int>> nextPerms = new List<IList<int>>();
            foreach (var p in perms)
            {
                for (int i = 0; i < p.Count + 1; i++)
                {
                    List<int> pCopy = new List<int>(p);
                    pCopy.Insert(i, n);
                    nextPerms.Add(pCopy);
                }
            }

            perms = nextPerms;
        }

        return perms; 
    }
}