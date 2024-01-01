namespace Algorithms.Leetcode.Arrays.Task7;

public class Solution
{
    public static int FindMin(int[] nums)
    {
        int min = nums[0];
        for (int i=0; i<nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }

        return min;
    }
}