namespace Algorithms.Leetcode.Binary.Task2;

public class Solution
{
    public static int HammingWeight(uint n)
    {
        if (n == 0) return 0; 
        var binaryN = Convert.ToString(n, 2);
        return binaryN.ToCharArray().Count(c => c == '1');
    }
}