namespace Algorithms.Leetcode.Arrays.Task8;

public class Solution
{
    public static int Search(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            if (target == nums[i])
            {
                return i;
            }
        }
        return -1;
    }
    
    public static int BinarySearch(int[] nums, int target)
    {
        var left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = (right + left) / 2;
            if (target == nums[mid])
            {
                return mid;
            }
            
            if (nums[left] <= nums[mid])
            {
                if (nums[left] <= target && target < nums[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && target <= nums[right])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return -1;
    }
}