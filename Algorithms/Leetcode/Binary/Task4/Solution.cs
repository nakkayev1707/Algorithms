namespace Algorithms.Leetcode.Binary.Task4;

public class Solution
{
    public static int MissingNumber(int[] nums)
    {
        int x = nums.Length;
	
        for (int i = 0; i < nums.Length; i++)
        {
            x ^= i ^ nums[i];
        }
	
        return x;
    }
}