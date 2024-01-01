namespace Algorithms.Leetcode.Arrays.Task5;

public class Solution
{
    public static int MaxSubArray(int[] nums)
    {
        throw new NotImplementedException();
    }
    
    public static int MaxSubArrayOptimized(int[] nums) {
        int sum = 0;
        int maxSum = nums[0];

        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (nums[i] > sum) {
                sum = nums[i];
            }
            if (sum > maxSum) { 
                maxSum = sum; 
            }
        }
        return maxSum;
    }
}