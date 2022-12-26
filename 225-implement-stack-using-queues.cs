// using System;
// using System.Collections.Generic;

public class MyStack
{
    private Queue<int> _queue;

    public MyStack()
    {
        _queue = new();
    }

    public void Push(int x)
        => _queue.Enqueue(x);

    public int Pop()
    {
        int move = _queue.Count - 1;
        for (int i = 0; i < move; i++)
            _queue.Enqueue(_queue.Dequeue());
        return _queue.Dequeue();
    }

    public int Top()
    {
        int move = _queue.Count - 1;
        for (int i = 0; i < move; i++)
            _queue.Enqueue(_queue.Dequeue());
        var ret = _queue.Dequeue();
        _queue.Enqueue(ret);
        return ret;
    }

    public bool Empty()
        => _queue.Count == 0;
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */