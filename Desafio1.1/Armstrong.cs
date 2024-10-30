using System;

public class Armstrong
{
    public static bool isArmstrong(int num)
    {
        var p = num.ToString().Length;
        var s = 0;
        var n = num;
        while (n != 0)
        {
            var d = n % 10;
            s += (int) Math.Pow(d, p);
            n -= d;
            n /= 10;
        }
        if (s == num) return true;
        return false;
    }
}
