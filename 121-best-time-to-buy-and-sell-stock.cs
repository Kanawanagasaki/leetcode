public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int bestProfit = 0;
        int currentProfit = 0;

        for(int i = 1; i < prices.Length; i++)
        {
            currentProfit = Math.Max(0, currentProfit + prices[i] - prices[i - 1]);
            bestProfit = Math.Max(bestProfit, currentProfit);
        }

        return bestProfit;
    }
}