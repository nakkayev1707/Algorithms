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

    public void PushBack(int n)
    {
        
    }

    public int PopBack()
    {
    }

    private void Resize()
    {
    }

    public int GetSize()
    {
    }

    public int GetCapacity()
    {
    }
}