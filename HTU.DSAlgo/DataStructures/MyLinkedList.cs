using System;
using System.Collections.Generic;

namespace HTU.DSAlgo.DataStructures
{
    public class MyLinkedList<T>
    {
        private LinkedListNode<T> First { get; set; }
        private LinkedListNode<T> Last { get; set; }
        public int Count { get; private set; }
        public bool IsNullOrEmpty => First == null;

        public T this[int index]
        {
            get
            {
                LinkedListNode<T> node = GetByIndex(index);
                if (node == null)
                {
                    throw new IndexOutOfRangeException();
                }
                return node.Value;
            }
            set
            {
                LinkedListNode<T> node = GetByIndex(index);
                if (node == null)
                {
                    throw new IndexOutOfRangeException();
                }
                node.Value = value;
            }
        }


        public MyLinkedList()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public void Add(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);

            if (IsNullOrEmpty)
            {
                First = newNode;
                Last = newNode;
            }
            else if (First.Next == null)
            {
                First.Next = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public int FindIndex(T value)
        {
            if (value == null || IsNullOrEmpty) return -1;
            LinkedListNode<T> node = First;

            for (int i = 0; i < Count; i++)
            {
                if (node.Value.Equals(value))
                    return i;
                node = node.Next;
            }
            return -1;
        }

        public void Insert(int index, T value)
        {
            if (index > Count)
                throw new ArgumentOutOfRangeException();
            if (index == 0)
            {
                First = new LinkedListNode<T>(value) { Next = First };
                Count++;
                return;
            }
            else if (index == Count)
            {
                Last.Next = new LinkedListNode<T>(value);
                Last = Last.Next;
                Count++;
            }
            else
            {
                LinkedListNode<T> node = GetByIndex(index - 1);
                node.Next = new LinkedListNode<T>(value) { Next = node.Next };
                Count++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index == 0)
            {
                First = First.Next;
                if (Count == 1)
                {
                    Last = null;
                }
            }
            else
            {
                LinkedListNode<T> prevNode = GetByIndex(index - 1);
                prevNode.Next = prevNode.Next.Next;
                if (index == Count - 1)
                {
                    Last = prevNode;
                }
            }

            Count--;
        }

        public bool Contains(T value)
        {
            if (IsNullOrEmpty || value == null)
            {
                return false;
            }

            LinkedListNode<T> node = First;
            while (node != null)
            {
                if (node.Value.Equals(value))
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public bool Remove(T value)
        {
            if (IsNullOrEmpty || value == null)
            {
                return false;
            }

            if (First.Value.Equals(value))
            {
                First = First.Next;
                Count--;
                if (First == null)
                {
                    Last = null;
                }
                return true;
            }

            LinkedListNode<T> prev = First;
            while (prev.Next != null)
            {
                if (prev.Next.Value.Equals(value))
                {
                    prev.Next = prev.Next.Next;
                    Count--;
                    if (prev.Next == null)
                    {
                        Last = prev;
                    }
                    return true;
                }
                prev = prev.Next;
            }

            return false;
        }

        public override string ToString()
        {
            string result = "";
            LinkedListNode<T> node = First;

            while (node != null)
            {
                result += node.ToString();
                if (node != Last) result += ", ";

                node = node.Next;

            }
            return result;
        }

        private LinkedListNode<T>? GetByIndex(int index)
        {
            LinkedListNode<T> node = First;

            for (int i = 0; i < index && node != null; i++)
                node = node.Next;

            return node;
        }

        private class LinkedListNode<T>
        {
            public T Value { get; set; }
            public LinkedListNode<T> Next { get; set; }

            public LinkedListNode(T value)
            {
                Value = value;
                Next = null;
            }

            public override string ToString()
            {
                return Value.ToString();
            }
        }
    }
}
