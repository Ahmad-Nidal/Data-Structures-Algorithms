using HTU.DSAlgo.Algorithms;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var arr = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            arr = arr.MergeSort();

            Console.WriteLine("--------------");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
