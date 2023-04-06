using DataStructures;
using HTU.DSAlgo.DataStructures;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MyList list = new MyList();
            //list.Fill(100);

            //Console.WriteLine(list);


            //List<int> test = new List<int>();
            //test.


            // doubly (next, prev)
            // indexers
            // debugging
            
            MyLinkedList<int> list = new MyLinkedList<int>();

            Console.WriteLine(list[1]);

            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            Console.WriteLine(list);
            //Console.WriteLine(list[2]);
            list.Insert(2, 1000);
            Console.WriteLine(list.IndexOf(1000));
            //Console.WriteLine(list[2]);
            Console.WriteLine(list);
        }
    }
}
