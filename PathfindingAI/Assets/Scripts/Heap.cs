using UnityEngine;
using System.Collections;
using System;

// class for structuring closer waypoints faster
public class Heap<T> where T : IHeapItem<T>
{
    
    T[] items; // waypoints
    int currentItemCount; // waypoints number

    // constructure
    public Heap(int maxHeapSize)
    {
        items = new T[maxHeapSize];
    }

    // adds item to bottom of the list then sorts them up
    public void Add(T item)
    {
        item.HeapIndex = currentItemCount;
        items[currentItemCount] = item;
        SortUp(item);
        currentItemCount++;
    }

    // removes first item then puts the biggest one first then sorts them down
    public T RemoveFirst()
    {
        T firstItem = items[0];
        currentItemCount--;
        items[0] = items[currentItemCount];
        items[0].HeapIndex = 0;
        SortDown(items[0]);
        return firstItem;
    }

    // if an item is changed they get sorted
    public void UpdateItem(T item)
    {
        SortUp(item);
    }

    // returns path waypoints count
    public int Count
    {
        get
        {
            return currentItemCount;
        }
    }

    // if an item is on the list
    public bool Contains(T item)
    {
        return Equals(items[item.HeapIndex], item);
    }

    // sorts an item from the bottom up
    void SortDown(T item)
    {
        while (true)
        {
            int childIndexLeft = item.HeapIndex * 2 + 1;
            int childIndexRight = item.HeapIndex * 2 + 2;
            int swapIndex = 0;

            if (childIndexLeft < currentItemCount)
            {
                swapIndex = childIndexLeft;

                if (childIndexRight < currentItemCount)
                {
                    if (items[childIndexLeft].CompareTo(items[childIndexRight]) < 0)
                    {
                        swapIndex = childIndexRight;
                    }
                }

                if (item.CompareTo(items[swapIndex]) < 0)
                {
                    Swap(item, items[swapIndex]);
                }
                else
                {
                    return;
                }

            }
            else
            {
                return;
            }

        }
    }

    // sorts an item from the top down
    void SortUp(T item)
    {
        int parentIndex = (item.HeapIndex - 1) / 2;

        while (true)
        {
            T parentItem = items[parentIndex];
            if (item.CompareTo(parentItem) > 0)
            {
                Swap(item, parentItem);
            }
            else
            {
                break;
            }

            parentIndex = (item.HeapIndex - 1) / 2;
        }
    }

    // swaps positions of the two items
    void Swap(T itemA, T itemB)
    {
        items[itemA.HeapIndex] = itemB;
        items[itemB.HeapIndex] = itemA;
        int itemAIndex = itemA.HeapIndex;
        itemA.HeapIndex = itemB.HeapIndex;
        itemB.HeapIndex = itemAIndex;
    }



}

// an items interface
public interface IHeapItem<T> : IComparable<T>
{
    int HeapIndex
    {
        get;
        set;
    }
}