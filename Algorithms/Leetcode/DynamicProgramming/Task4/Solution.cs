namespace Algorithms.Leetcode.DynamicProgramming.Task4;

public class Solution
{
    // Input: text1 = "abcde", text2 = "ace" 
    // Output: 3  
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        int len1 = text1.Length;
        int len2 = text2.Length;

        return LCS(text1, text2, len1, len2);
    }

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