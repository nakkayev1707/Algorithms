namespace Algorithms.Practice;

public class BinarySearch
{
    public static int? Search(int[] array, int n)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (array[mid] == n) return array[mid];
            
            if (array[mid] < n)
            {
                right = mid - 1;
            }

            if (array[mid] > n)
            {
                left = mid + 1;
            }
        }

        return null;
    }
}