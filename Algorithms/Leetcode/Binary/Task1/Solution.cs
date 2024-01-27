namespace Algorithms.Leetcode.Binary.Task1;

public class Solution
{
    public static int GetSum(int a, int b) {
        while (b != 0) {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}