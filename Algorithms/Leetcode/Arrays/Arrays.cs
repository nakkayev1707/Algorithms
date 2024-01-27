using Xunit;

namespace Algorithms.Leetcode.Arrays;

public class Arrays
{
    public static void Run()
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // Task7();
        // Task8();
        // Task9();
    }

    private static void Task9()
    {
        int[] nums1 = {-1, 0, 1, 2, -1, -4};
        IList<IList<int>> triples = Leetcode.Arrays.Task9.Solution.ThreeSum(nums1);
       
        for (int i = 0; i < triples.Count; i++)
        {
            PrintArray(triples[i].ToArray());
        }
    }

    private static void Task8()
    {
        int[] nums1 = {4,5,6,7,0,1,2};
        var target1 = 0;
        int min1 = Leetcode.Arrays.Task8.Solution.BinarySearch(nums1, target1);
        Console.WriteLine(min1);
        
        int[] nums2 = {4,5,6,7,0,1,2};
        var target2 = 3;
        int min2 = Leetcode.Arrays.Task8.Solution.BinarySearch(nums2, target2);
        Console.WriteLine(min2);
        
        int[] nums3 = {1};
        var target3 = 0;
        int min3 = Leetcode.Arrays.Task8.Solution.BinarySearch(nums3, target3);
        Console.WriteLine(min3);
    }

    private static void Task7()
    {
        int[] nums1 = {2, 3, -2, 4};
        int min = Leetcode.Arrays.Task7.Solution.FindMin(nums1);
        Console.WriteLine(min);
    }

    private static void Task6()
    {
        int[] nums1 = {2, 3, -2, 4};
        int res1 = Leetcode.Arrays.Task6.Solution.MaxProduct(nums1);
        Console.WriteLine(res1);

        int[] nums2 = {-2, 0, 1};
        int res2 = Leetcode.Arrays.Task6.Solution.MaxProduct(nums2);
        Console.WriteLine(res2);
    }
    
    private static void Task5()
    {
        int[] nums1 = {-2, 1, -3, 4, -1, 2, 1, -5, 4};
        int res1 = Leetcode.Arrays.Task5.Solution.MaxSubArrayOptimized(nums1);
        Assert.Equal(6, res1);

        int[] nums2 = {1};
        int res2 = Leetcode.Arrays.Task5.Solution.MaxSubArrayOptimized(nums2);
        Assert.Equal(1, res2);

        int[] nums3 = {5, 4, -1, 7, 8};
        int res3 = Leetcode.Arrays.Task5.Solution.MaxSubArrayOptimized(nums3);
        Assert.Equal(23, res3);
    }

    private static void Task4()
    {
        int[] nums1 = {1, 2, 3, 4};
        PrintArray(Leetcode.Arrays.Task4.Solution.ProductExceptSelfOptimized(nums1));

        int[] nums2 = {-1, 1, 0, -3, 3};
        PrintArray(Leetcode.Arrays.Task4.Solution.ProductExceptSelfOptimized(nums2));
    }

    private static void Task3()
    {
        int[] nums1 = {1,2,3,1};
        Console.WriteLine(Leetcode.Arrays.Task3.Solution.ContainsDuplicate(nums1));

        int[] nums2 = {1, 2, 3, 4};
        Console.WriteLine(Leetcode.Arrays.Task3.Solution.ContainsDuplicate(nums2));
        
        int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Console.WriteLine(Leetcode.Arrays.Task3.Solution.ContainsDuplicate(nums3));
    }

    private static void Task2()
    {
        int[] prices1 = {7, 1, 5, 3, 6, 4};
        Console.WriteLine(Leetcode.Arrays.Task2.Solution.MaxProfitOptimized(prices1));
        
        int[] prices2 = {7,6,4,3,1};
        Console.WriteLine(Leetcode.Arrays.Task2.Solution.MaxProfitOptimized(prices2));
    }

    private static void Task1()
    {
        int[] twoSum = Algorithms.Leetcode.Arrays.Task1.Solution.TwoSumOptimized(new[] {3, 2, 4}, 6);
        PrintArray(twoSum);
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine("[{0}]", string.Join(", ", array));
    }
}