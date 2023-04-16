using DataStructures;
using HTU.DSAlgo.DataStructures;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyDynamicStack<int> myStack = new MyDynamicStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Print();
            Console.WriteLine("---------------");
            myStack.Pop();
            Console.WriteLine("---------------");
            myStack.Print();
        }
    }
}
