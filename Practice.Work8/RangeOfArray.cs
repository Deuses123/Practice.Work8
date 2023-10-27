namespace Practice.Work8;

using System;

public class RangeOfArray
{
    private int[] array;
    private int startIndex;

    public RangeOfArray(int startIndex, int endIndex)
    {
        if (startIndex > endIndex)
        {
            throw new ArgumentException("Начальный индекс должен быть меньше или равен конечному индексу.");
        }

        this.startIndex = startIndex;
        int size = endIndex - startIndex + 1;
        array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            if (IsIndexValid(index))
            {
                return array[index - startIndex];
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
            }
        }
        set
        {
            if (IsIndexValid(index))
            {
                array[index - startIndex] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Индекс вне допустимого диапазона.");
            }
        }
    }

    private bool IsIndexValid(int index)
    {
        return index >= startIndex && index <= startIndex + array.Length - 1;
    }
}
