namespace Algorithms.Leetcode.Arrays.Task4;

public class Solution
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        var answer = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            var answerItem = 1;
            for (var j = 0; j < nums.Length; j++)
            {
                if (i != j) answerItem *= nums[j];
            }
            answer[i] = answerItem;
        }

        return answer;
    }

    public static int[] ProductExceptSelfOptimized(int[] nums)
    {
        var answer = new int[nums.Length];
        int length = nums.Length;

        var prev1 = 1;
        for (var i = 0; i < length; i++)
        {
            answer[i] = prev1;
            prev1 = nums[i] * prev1;
        }

        var prev2 = 1;
        for (int i = length - 1; i >= 0; i--)
        {
            answer[i] = answer[i] * prev2;
            prev2 = nums[i] * prev2;
        }
        return answer;
    }
}