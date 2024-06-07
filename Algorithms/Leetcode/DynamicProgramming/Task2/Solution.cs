namespace Algorithms.Leetcode.DynamicProgramming.Task2;

public class Solution
{
    // input [1,2,5] 11
    // output 3
    public static int CoinChange(int[] coins, int amount)
    {
        int max = amount + 1;
        int[] dp = new int[amount + 1];
        Array.Fill(dp, max);
        dp[0] = 0;
        
        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (i >= coin)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }
        
        return dp[amount] == max ? -1 : dp[amount];
    }
}