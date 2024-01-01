namespace Algorithms.Leetcode.Arrays.Task3;

public class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}