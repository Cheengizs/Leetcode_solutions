namespace Task_121;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length - 1; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] - prices[i] > maxProfit)
                {
                    string s = "isfqweunfoqf";
                    var x = s.Reverse();
                }
            }
        }

        return 3;
    }
}