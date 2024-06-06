namespace Algorithms.Leetcode.DynamicProgramming.Task2;

public class Solution
{
    public static int CoinChange(int[] coins, int amount)
    {
        int max = coins[0];
        for (int i = 0; i < coins.Length; i++)
        {
            if (coins[i] > max)
            {
                max = coins[i];
            }
        }

        if (max < amount) return -1;

        int result = 0;
        int sum = 0;
        while (sum != amount)
        {
            
        }

        return result;
    }
}