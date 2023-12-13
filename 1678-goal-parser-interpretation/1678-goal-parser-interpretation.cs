public class Solution {
    public string Interpret(string command) {
         int i = 0;
        StringBuilder sb = new();
        while (i < command.Length)
        {
            if (command[i] == 'G')
            {
                sb.Append('G');
                i++;
            }
            else if (command[i] == '(' && command[i+1] == ')')
            {
                sb.Append('o');
                i += 2;
            }
            else
            {
                sb.Append("al");
                i += 4;
            }
        }

        return sb.ToString();
    }
}