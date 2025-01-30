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
        if (string.IsNullOrEmpty(s)) return true;
        if (!wordDict.Any()) return false;

        foreach (string word in wordDict)
        {
            s = s.Replace(word, "");
            if (string.IsNullOrEmpty(s)) return true;
        }
        
        return false;
    }
}