namespace Algorithms.Leetcode.DynamicProgramming.Task4;

public class Solution
{
    // Input: text1 = "abcde", text2 = "ace" 
    // Output: 3  
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        int len1 = text1.Length;
        int len2 = text2.Length;

        if (len1 == 0 || len2 == 0)
        {
            return 0;
        }

        var dp = new int[len1 + 1, len2 + 1];

        for (int i = 1; i <= len1; i++)
        {
            for (int j = 1; j <= len2; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i, j] = 1 + dp[i - 1, j - 1];
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                }
            }
        }

        return dp[len1, len2];
    }
    
    /// solution using recursion
    /// return LCS(text1, text2, len1, len2);
    private static int LCS(string str1, string str2, int len1, int len2)
    {
        if (len1 == 0 || len2 == 0) return 0;
    
        if (str1[len1 - 1] == str2[len2 - 1])
        {
            return 1 + LCS(str1, str2, len1 - 1, len2 - 1);
        }
    
        return Math.Max(LCS(str1, str2, len1, len2 -1), LCS(str1, str2, len1 - 1, len2));
    }
}