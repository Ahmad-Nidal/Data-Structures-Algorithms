using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTU.DSAlgo.DataStructures.Lenear
{
    public class MyFixedStack<T>
    {
        private T[] _arr;
        private int _top;
        private int _size;
        public MyFixedStack(int size)
        {
            _arr = new T[size];
            _top = -1;
            _size = size;
        }

        public void push(T item)
        {
            if (_top == _size - 1)
            {
                throw new Exception("Stack Overflow");
            }
            else
            {
                _arr[++_top] = item;
            }
        }

        public T pop()
        {
            if (_top == -1)
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                Console.WriteLine(_arr[_top]);
                return _arr[_top--];
            }
        }

        public void Print()
        {
            if (_top == -1)
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                for (int i = 0; i <= _top; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            }
        }
    }
}
