namespace Algorithms.Leetcode.DynamicProgramming;

public class DynamicProgramming
{
    public static void Run()
    {
        // Task1();
        // Task2();
        // Task3();
        Task4();
    }
    
    private static void Task1()
    {
        int result = Algorithms.Leetcode.DynamicProgramming.Task1.Solution.ClimbStairs(3);
        Console.WriteLine(result);
    }
    
    private static void Task2()
    {
        int result = Algorithms.Leetcode.DynamicProgramming.Task2.Solution.CoinChange(new []{1,2,5}, 11);
        Console.WriteLine(result);
    }

    private static void Task3()
    {
        int result = Algorithms.Leetcode.DynamicProgramming.Task3.Solution.LengthOfLIS(new []{10,9,2,5,3,7,101,18});
        Console.WriteLine(result);
    }
    
    private static void Task4()
    {
        int result = Algorithms.Leetcode.DynamicProgramming.Task4.Solution.LongestCommonSubsequence("abc", "abc");
        Console.WriteLine(result);
    }
}