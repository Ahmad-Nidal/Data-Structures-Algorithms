using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTU.DSAlgo.DataStructures.Lenear
{
    public class MyDynamicStack<T>
    {
        private StackNode<T> _top { get; set; }
        public int Count { get; set; }
        public bool IsNullOrEmpty => _top == null;

        public MyDynamicStack()
        {
            _top = null;
            Count = 0;
        }

        public void Push(T value)
        {
            StackNode<T> newNode = new StackNode<T>(value);
            if (IsNullOrEmpty)
            {
                _top = newNode;
            }
            else
            {
                newNode.Prev = _top;
                _top = newNode;
            }
            Count++;
        }

        public T Pop()
        {
            if (!IsNullOrEmpty)
            {
                T value = _top.Value;
                _top = _top.Prev;
                Count--;
                return value;
            }
            else
            {
                throw new Exception("Stack is Empty");
            }
        }

        public T Top()
        {
            if (!IsNullOrEmpty)
            {
                return _top.Value;
            }
            else
            {
                throw new Exception("Stack is Empty");
            }
        }

        public void Print()
        {
            StackNode<T> tmpTop = _top;
            while (tmpTop != null)
            {
                Console.WriteLine(tmpTop.Value);
                tmpTop = tmpTop.Prev;
            }
        }
        private class StackNode<T>
        {
            internal T Value { get; set; }
            internal StackNode<T> Prev;

            public StackNode(T value)
            {
                Value = value;
                Prev = null;
            }
        }
    }
}
