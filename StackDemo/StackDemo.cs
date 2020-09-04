using System;
using System.Collections.Generic;

namespace StackModel
{ 
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();

        }
    }

    public class Stack
    {
        List<Object> st = new List<Object>();
        public int top{ get; set; }
        public Stack()
        {
            top = -1;
        }
        public void Push(Object obj)
        {
            if (obj != null)
            {
                st.Add(obj);
                top += 1;
            }
        }

        public object Pop()
        {
            if (top == -1)
            {
                return "Stack Underflow";
            }
            else
            {
                object temp = st[top];
                st.RemoveAt(top);
                top -= 1;
                return temp;
                
            }
        }

        public void Clear()
        {
            st.Clear();
            top = -1;
        }
    }
    
}
