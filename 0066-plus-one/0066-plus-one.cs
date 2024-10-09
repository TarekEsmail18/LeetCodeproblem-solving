public class Solution {
    public int[] PlusOne(int[] digits) {
        if (digits[digits.Length - 1] != 9)
            digits[digits.Length - 1] += 1;
        else
        {
            for (int i = digits.Length - 1; i >=0; i--)
            {
                if (digits[i] == 9)
                {
                    //digits[i] = 0;
                    if(i == 0)
                    {
                        digits = new int[digits.Length + 1];
                        digits[digits.Length - 1] = 0;
                        digits[0] = 1;
                    }    
                    else
                    {
                        digits[i] = 0;
                        if(digits[i - 1] != 9)
                        {
                            digits[i - 1] += 1;
                            break;
                        }
                        //return digits;
                    }
                }
            }

        }

        return digits;
    }
}