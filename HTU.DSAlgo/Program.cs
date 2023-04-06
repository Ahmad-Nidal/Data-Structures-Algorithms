using DataStructures;
using HTU.DSAlgo.DataStructures;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyLinkedList<int> linkedList = new MyLinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            Console.WriteLine(linkedList);
        }
    }
}
