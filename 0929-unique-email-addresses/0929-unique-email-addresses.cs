public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> hashSet = new();
        foreach (var eachEmail in emails)
        {
            var splitEmailDomain = eachEmail.Split('@');
            StringBuilder newEmail = new StringBuilder();
            int slow = 0, fast = 0;
            bool isDomain = false;
            StringBuilder emailAdd = new StringBuilder(splitEmailDomain[0]);
            while (fast < emailAdd.Length)
            {
                if (emailAdd[fast] == '.')
                {
                    slow++;
                    fast++;
                }
                else if (emailAdd[fast] == '+')
                {
                    fast++;
                    break;
                }
                else
                {
                    newEmail.Append(emailAdd[slow]);
                    slow++;
                    fast++;
                }
            }

            hashSet.Add(newEmail.ToString() + '@' + splitEmailDomain[1]);
        }

        return hashSet.Count;
    }
}