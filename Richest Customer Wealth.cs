public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int x = 0;
        int y = 0;
        for (int i = 0; i < accounts.Length; ++i)
        {
            for (int j = 0; j < accounts[i].Length; ++j)
            {
                y += accounts[i].ElementAt(j);
            }
            if (y > x)
            {
                x = y;
                y = 0;
            }
            y = 0;
        }

        return x;
    }
}