using HTU.DSAlgo.Algorithms;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var list = new List<int> { 4, 5, 1, 3, 2, 7, 8, 9 };
            var list2 = new List<int> { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            list.SelectionSort();
            list2.SelectionSort();

            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("--------------");
            list2.ForEach(x => Console.WriteLine(x));
        }
    }
}
