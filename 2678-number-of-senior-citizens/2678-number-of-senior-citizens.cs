public class Solution {
    public int CountSeniors(string[] details) {
        int personCounter = 0;
        foreach (var detail in details)
        {
            if (Convert.ToInt32(detail.Substring(11, 2))>60)
            {
                personCounter ++;
            }
        } return personCounter;
    }
}