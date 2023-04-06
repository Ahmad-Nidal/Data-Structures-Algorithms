using System;
using System.Collections.Generic;

namespace HTU.DSAlgo.DataStructures
{
    public class MyLinkedList<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty => Head == null;

        public T this[int index]
        {
            get
            {
                Node<T> node = getByIndex(index);
                if (node == null)
                {
                    throw new IndexOutOfRangeException();
                }
                return node.Value;
            }
            set
            {
                Node<T> node = getByIndex(index);
                if (node == null)
                {
                    throw new IndexOutOfRangeException();
                }
                node.Value = value;
            }
        }


        public MyLinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else if (Head.Next == null)
            {
                Head.Next = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public int IndexOf(T value)
        {
            if (value == null || IsEmpty) return -1;
            Node<T> node = Head;

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
            if (index == 0)
            {
                Head = new Node<T>(value) { Next = Head };
                Count++;
                return;
            }
            if (index < Count)
            {
                Node<T> node = getByIndex(index - 1);
                node.Next = new Node<T>(value) { Next = node.Next };
                Count++;
            }
            else if (index == Count)
            {
                Tail.Next = new Node<T>(value);
                Tail = Tail.Next;
                Count++;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (index == 0)
            {
                Head = Head.Next;
                if (Count == 1)
                {
                    Tail = null;
                }
            }
            else
            {
                Node<T> prevNode = getByIndex(index - 1);
                prevNode.Next = prevNode.Next.Next;
                if (index == Count - 1)
                {
                    Tail = prevNode;
                }
            }

            Count--;
        }

        public bool Contains(T value)
        {
            if (IsEmpty || value == null)
            {
                return false;
            }

            Node<T> node = Head;
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
            if (IsEmpty || value == null)
            {
                return false;
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                Count--;
                if (Head == null)
                {
                    Tail = null;
                }
                return true;
            }

            Node<T> prev = Head;
            while (prev.Next != null)
            {
                if (prev.Next.Value.Equals(value))
                {
                    prev.Next = prev.Next.Next;
                    Count--;
                    if (prev.Next == null)
                    {
                        Tail = prev;
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
            Node<T> node = Head;

            while (node != null)
            {
                result += node.ToString();
                if (node != Tail) result += ", ";

                node = node.Next;

            }
            return result;
        }
        private Node<T>? getByIndex(int index)
        {
            Node<T> node = Head;
            try
            {
                for (int i = 0; i < index; i++)
                    node = node.Next;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return node;
        }


        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value)
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
