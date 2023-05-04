using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;




public class Stack<T>
{
    private T[] items;
    private int count;

    public Stack(int size)
    {
        items = new T[size];
        count = 0;
    }

    public void Push(T item)
    {
        if (count == items.Length)
        {
            throw new InvalidOperationException("Стек переполнен");
        }

        items[count++] = item;
    }

    public T Pop()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        return items[--count];
    }

    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }

        return items[count - 1];
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public int Count
    {
        get
        {
            return count;
        }
    }
}
