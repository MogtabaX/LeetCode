class Solution
{
    static void Main()
    {
        scoreOfString("zaz");
    }
    public static int scoreOfString(String s)
    {
        int x = 0;
        for (int i = 0; i < s.Length-1; ++i)
        {
            x += Math.Abs((int)(s[i] - s[i + 1]));
        }
        return x;
    }
}