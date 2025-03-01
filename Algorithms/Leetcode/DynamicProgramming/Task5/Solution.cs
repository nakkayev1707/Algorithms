namespace Algorithms.Leetcode.DynamicProgramming.Task5;

public class Solution
{
    // Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
    // Output: false
    
    // Input: s = "applepenapple", wordDict = ["apple","pen"]
    // Output: true
    
    // ["car","ca","rs"]
    // true
    public static bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;

        for (var i = 1; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        
        return dp[s.Length];
    }
}