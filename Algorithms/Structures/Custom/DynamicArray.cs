using Xunit;

namespace Algorithms.Structures.Custom;

public class DynamicArray
{
    private int[] arr;
    
    public DynamicArray(int capacity)
    {
        Assert.True(capacity > 0);
        arr = new int[capacity];
    }

    public int Get(int i)
    {
        Assert.True(i >= 0);
        return arr[i];
    }

    public void Set(int i, int n)
    {
        Assert.True(i >= 0);
        arr[i] = n;
    }

    // todo: finish impl
    public void PushBack(int n)
    {
        arr[^1] = n;
    }

    // todo: finish impl
    public int PopBack()
    {
        return arr[^1];
    }

    private void Resize()
    {
        var newArr = new int[2 * arr.Length];
        for (var i = 0; i < arr.Length; i ++)
        {
            newArr[i] = arr[i];
        }

        arr = newArr;
    }

    public int GetSize()
    {
        return arr.Length;
    }

    public int GetCapacity()
    {
        throw new NotImplementedException();
    }
}