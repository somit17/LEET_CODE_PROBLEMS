public class MinStack {
    public Stack<int> stack;
    public Stack<int> minStack;
    public MinStack() {
        stack=new();
        minStack=new();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count>0 && val > minStack.Peek())
            minStack.Push(minStack.Peek());
        else minStack.Push(val);
    }
    
    public void Pop() {
        if (stack.Count != 0)
        {
            stack.Pop();
            minStack.Pop();
        }  
    }
    
    public int Top() {
        return stack.Count>0?stack.Peek():0;
    }
    
    public int GetMin() {
        return minStack.Count > 0? minStack.Peek():0;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */