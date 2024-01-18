public class Solution {
    public bool HalvesAreAlike(string s) {
         List<char> vowels = new List<char>()
        {
            'a', 'e', 'i', 'o', 'u'
        };
        int iCounter = 0,lPointer=0,rPointer=s.Length-1,lCounter=0,rCounter=0;
        while (iCounter < s.Length / 2)
        {
            iCounter++;
            if (vowels.Contains(Char.ToLower(s[lPointer])))
            {
                
                lCounter++;
            }
            if (vowels.Contains(Char.ToLower(s[rPointer])))
            {
                
                rCounter++;
            }rPointer--;lPointer++;
        }

        if (lCounter == rCounter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}