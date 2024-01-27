using Algorithms.Leetcode.Binary.Task1;

namespace Algorithms.Leetcode.Binary;

public class Binary
{
    public static void Run()
    {
        Task1();
    }
    
    
    private static void Task1()
    {
        int sum = Algorithms.Leetcode.Binary.Task1.Solution.GetSum(1,6);
        Console.WriteLine(sum);
    }
}