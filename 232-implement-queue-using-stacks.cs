// using System;
// using System.Collections.Generic;

public class MyQueue
{
    private Stack<int> _stack1;
    private Stack<int> _stack2;

    public MyQueue()
    {
        _stack1 = new();
        _stack2 = new();
    }

    public void Push(int x)
        => _stack1.Push(x);

    public int Pop()
    {
        if(_stack2.Count > 0)
            return _stack2.Pop();
        while (_stack1.TryPop(out var el))
            _stack2.Push(el);
        return _stack2.Pop();
    }

    public int Peek()
    {
        if(_stack2.Count > 0)
            return _stack2.Peek();
        while (_stack1.TryPop(out var el))
            _stack2.Push(el);
        return _stack2.Peek();
    }

    public bool Empty()
        => _stack1.Count == 0 && _stack2.Count == 0;
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */