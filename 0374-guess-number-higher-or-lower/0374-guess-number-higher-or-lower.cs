/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
      int L=0,R=n-1;
        while(L<=R)
        {
            int guessNo=L+(R-L)/2;
            int result=guess(guessNo);
            if(result==0) return guessNo;
            else if(result==1)L=guessNo+1;
            else R=guessNo-1;
        }
        return n;
    }
}