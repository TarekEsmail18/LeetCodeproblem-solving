public class Solution {
    public bool IsPalindrome(int x) {
        string value = x.ToString();
        char[] arr = value.ToCharArray();
        List<int> z = new List<int>();
        List<int> zRev = new List<int>();
        for(int i = 0; i < arr.Length; i++)
        {
            z.Add(arr[i]);
        }
        for(int i = arr.Length-1; i >= 0; i--)
        {
            zRev.Add(arr[i]);
        }
        return z.SequenceEqual(zRev);
        
    }
}