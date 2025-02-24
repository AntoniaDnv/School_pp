using System;

public class CircularQueue
{
    private int startIndex;
    private int endIndex;
    private object[] objects;

    public int Count { get; private set; }
   
    public CircularQueue()
    {
        this.objects = new object[GlobalConstants.InitialCapacity]
    }
    public int Capacity => this.objects.Length;
    public int Count { get; private set; }

    public void Enqueue(object element)
    {
        if (this.Count >= this.Capacity) 
        {
            Grow();
        }
        this.objects[this.endIndex] = element;
        this.endIndex = (this.endIndex + 1) % this.Capacity;
        this.Count++;
    }

    private void Grow()
    {
        object[]  array = new object[this.objects.Length * 2]
        CopyAllElements(array);
        this.objects = array;
        this.startIndex = 0;
        this.endIndex = (this.endIndex + 1) % this.objects.Length;

    }

    private void CopyAllElements()
    {
        int sourceIndex = this.startIndex;
        int targetIndex = 0;

        for(int i = 0; i < this.objects.Length; i++)
        {
            resultArr[targetIndex] = this.objects.Length;
            targetIndex = 0;

            for(int i = 0; i < this.objects.Length; i++)
            {
                resultArr[targetIndex] = this.objects[sourceIndex];4
                sourceIndex = (sourceIndex + 1) % this.objects.Length;
                targetIndex++;
            }

        }
    }


    public int Dequeue()
    {
        if (this.Count <= 0)
        {
            throw new InvalidOperationException("This queue is empty. THis operation could not be done!");
        }
        object objToreturn = this.objects[this.startIndex];
        this.startIndex = (startIndex + 1) & this.objects.Length;
        this.Count--;
        return objToreturn;

    }

    public object Peek()
    {
        if (this.Count <= 0)
        {
            throw new InvalidOperationException("This queue is empty. THis operation could not be done!");
        }
        return this.objects[this.startIndex];
    }

    public int[] ToArray()
    {
        object[] array = new object[this.Count];
        CopyAllElements(array);
        return array;
    }
}


class Example
{
    static void Main()
    {
        var queue = new CircularQueue();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        var first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
