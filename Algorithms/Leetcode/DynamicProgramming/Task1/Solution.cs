namespace Algorithms.Leetcode.DynamicProgramming.Task1;

public class Solution
{
    public static int ClimbStairs(int n)
    {
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 1 == 0 || i % 2 == 0)
            {
                result++;
            }
        }

        return result;
    }
}