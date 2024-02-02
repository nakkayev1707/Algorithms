namespace Algorithms.Leetcode.Binary.Task3;

public class Solution
{
    public static int[] CountBits(int n)
    {
        var ans = new int[n+1];
        for (var i = 0; i <= n; i++)
        {
            ans[i] = Convert.ToString(i, 2).Count(c => c == '1');
        }

        return ans;
    }
}