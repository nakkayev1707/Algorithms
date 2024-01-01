namespace Algorithms.Leetcode.Arrays.Task2;

public class Solution
{
    public static int MaxProfit(int[] prices)
    {
        int lenght = prices.Length;
        var maxProfit = 0;
        for (var i = 0; i < lenght; i++)
        {
            for (int j = i + 1; j < lenght; j++)
            {
                if (prices[j] - prices[i] > maxProfit)
                {
                    maxProfit = prices[j] - prices[i];
                }
            }
        }

        return maxProfit;
    }

    public static int MaxProfitOptimized(int[] prices)
    {
        int lenght = prices.Length;
        var maxProfit = 0;
        int min = prices[0];
        
        for (var i = 0; i < lenght; i++)
        {
            if (prices[i] < min)
            {
                min = prices[i];
            } else if ((prices[i] - min) > maxProfit)
            {
                maxProfit = prices[i] - min;
            }
        }

        return maxProfit;
    }
}