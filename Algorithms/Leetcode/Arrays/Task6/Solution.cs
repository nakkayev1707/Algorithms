namespace Algorithms.Leetcode.Arrays.Task6;

public class Solution
{
    public static int MaxProduct(int[] nums)
    {
        
        // TODO: Finish implementation, return to this task in Leetcode
        int product = 0;
        var maxProduct = nums[0];

        for (var i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
            
            if (nums[i] > product)
            {
                product = nums[i];
            }

            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        return maxProduct;
    }
}