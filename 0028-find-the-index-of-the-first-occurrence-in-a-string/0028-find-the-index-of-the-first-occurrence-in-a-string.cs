public class Solution {
    public int StrStr(string haystack, string needle) {
        int j = 0;
        int index = -1;
        int firstEnter = 0;
        bool enter = false;
        for (int i = 0; i < haystack.Length;)
        {
            if(j < needle.Length)
            {
                if (haystack[i] == needle[j])
                {

                    if(firstEnter == 0)
                        index = i;

                    if (firstEnter == needle.Length - 1)
                        return index;
                    enter = true;
                    firstEnter++;
                    j++;

                }
                if (!enter)
                {
                    if(i > 0 && j > 0)
                    {
                        if (haystack[i] != needle[j] && haystack[i - 1] == needle[j - 1])
                        {
                            i = index + 1;
                            j = 0;
                            firstEnter = 0;

                        }
                        else
                        {
                            firstEnter = 0;
                            i++;
                        }

                    }
                    else
                    {
                        i++;
                    }

                }
                else
                {
                    i++;
                }
                enter = false;
            }
        }
        index = -1;
        return index;
    }
}