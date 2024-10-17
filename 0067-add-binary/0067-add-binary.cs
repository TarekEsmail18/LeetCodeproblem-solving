public class Solution {
    public string AddBinary(string a, string b) {
        int length = a.Length > b.Length ? a.Length : b.Length;
        char[] OutPut = new char[length + 1];  
        int Remain = 0;
        string s = "";
        int j = 1;
        int k = 0;
        if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, '0');
        }
        else if (a.Length > b.Length) 
        { 
           b = b.PadLeft(a.Length,'0');
        }

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == '1' && b[i] == '1' && Remain == 0)
            {
                OutPut[OutPut.Length - j] = '0';
                Remain = 1;
            }
            else if (a[i] == '1' && b[i] == '1' && Remain == 1)
            {
                OutPut[OutPut.Length - j] = '1';
                Remain = 1;
            }
            else if (a[i] == '0' && b[i] == '1' && Remain == 0)
            {
                OutPut[OutPut.Length - j] = '1';
            }
            else if (a[i] == '0' && b[i] == '1' && Remain == 1)
            {
                OutPut[OutPut.Length - j] = '0';
                Remain = 1;
            }
            else if (a[i] == '1' && b[i] == '0' && Remain == 0)
            {
                OutPut[OutPut.Length - j] = '1';
            }
            else if (a[i] == '1' && b[i] == '0' && Remain == 1)
            {
                OutPut[OutPut.Length - j] = '0';
                Remain = 1;
            }
            else if (a[i] == '0' && b[i] == '0' && Remain == 0)
            {
                OutPut[OutPut.Length - j] = '0';
            }
            else if (a[i] == '0' && b[i] == '0' && Remain == 1)
            {
                OutPut[OutPut.Length - j] = '1';
                Remain = 0;
            }
            
            j++;
        }
        if (Remain == 1)
        {
            OutPut[0] = '1';
        }
        else
        {
            k = 1;
        }
        for (int i = k; i < OutPut.Length; i++)
        {
            s += OutPut[i];
        }
        return s;
    }
}