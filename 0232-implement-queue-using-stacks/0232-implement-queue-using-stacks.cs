public class MyQueue {

    private Stack<int> queue;
    private Stack<int> temp;

    public MyQueue()
    {
        queue = new();
         temp = new();
    }

    public void Push(int x)
    {
        queue.Push(x);
    }

    public int Pop()
    {
        if (temp.Any())
        {
            return temp.Pop();
        }
        while (queue.Any())
        {
            temp.Push(queue.Pop());
        }
        return temp.Pop();
    }

    public int Peek()
    {
        if (temp.Any())
        {
            return temp.Peek();
        }
        while (queue.Any())
        {
            temp.Push(queue.Pop());
        }
        return temp.Peek();
    }

    public bool Empty()
    {
       return queue.Count==0 && temp.Count==0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */