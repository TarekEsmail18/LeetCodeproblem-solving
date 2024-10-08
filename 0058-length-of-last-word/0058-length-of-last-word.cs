public class Solution {
    public int LengthOfLastWord(string s) {
        int length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                length++;
            }
            else if (s[i] == ' ' && length != 0)
            {
                return length;
            }

        }
        return length;
    }
}