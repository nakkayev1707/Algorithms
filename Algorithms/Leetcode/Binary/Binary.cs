
namespace Algorithms.Leetcode.Binary;

public class Binary
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
        int sum = Algorithms.Leetcode.Binary.Task1.Solution.GetSum(1,6);
        Console.WriteLine(sum);
    }

    private static void Task2()
    {
        int weight = Algorithms.Leetcode.Binary.Task2.Solution.HammingWeight(4);
        Console.WriteLine(weight);
    }

    private static void Task3()
    {
        int[] arr = Algorithms.Leetcode.Binary.Task3.Solution.CountBits(4);
    }

    private static void Task4()
    {
        int result = Algorithms.Leetcode.Binary.Task4.Solution.MissingNumber(new []{0, 1, 2, 4, 5});
        Console.WriteLine(result);
    }
}