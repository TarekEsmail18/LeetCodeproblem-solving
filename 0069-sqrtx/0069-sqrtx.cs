public class Solution {
    public int MySqrt(int x) {
        double i = 0;
        double y = 0;
        if (x <= 1)
        {
            return x;
        }
        while(i <= x)
        {
            y = i * i;
            if (y > x)
            {
                return (int)i - 1;
                break;
            }
            i++;
        }
        return 0;
    }
}