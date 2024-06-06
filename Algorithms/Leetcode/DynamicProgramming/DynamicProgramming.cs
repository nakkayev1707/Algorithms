namespace Algorithms.Leetcode.DynamicProgramming;

public class DynamicProgramming
{
    public static void Run()
    {
        Task1();
        Task2();
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
}