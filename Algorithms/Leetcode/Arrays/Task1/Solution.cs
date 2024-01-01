namespace Algorithms.Leetcode.Arrays.Task1;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int[] answer = new int[2];
        int lenght = nums.Length;

        for (int i = 0; i < lenght; i++ )
        {
            for (int j = i + 1; j < lenght; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    answer[0] = i;
                    answer[1] = j;
                }
            }
        }

        return answer;
    }

    public static int[] TwoSumOptimized(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(seen.ContainsKey(target-nums[i])){
                return new int[]{seen[target-nums[i]], i};
            }
            if(!seen.ContainsKey(nums[i])){
                seen.Add(nums[i], i);
            }
            
        }
        return null;
    }
}