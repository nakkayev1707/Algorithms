namespace Algorithms.Leetcode.DynamicProgramming.Task3;

public static class Solution
{
    // Input: nums = [10,9,2,5,3,7,101,18]
    // Output: 4
    public static int LengthOfLIS(int[]? nums)
    {
        if (nums == null || nums.Length == 0) return 0;

        int n = nums.Length;
        int[] dp = new int[n];
        
        Array.Fill(dp, 1);

        int maxLength = 1;
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j ++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            maxLength = Math.Max(maxLength, dp[i]);
        }

        return maxLength;
    }
}