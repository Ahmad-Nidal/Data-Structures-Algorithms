

namespace HTU.DSAlgo.Algorithms
{
    public static class SortingExtention
    {
        public static void SelectionSort(this List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                // find min from i(sorted from) to end
                var min = list[i];
                var indexOfMin = i;
                int j = i;
                for (; j < list.Count; j++)
                {
                    if (list[j] < min)
                    {
                        min = list[j];
                        indexOfMin = j;
                    }
                }
                // swap list[i] with min
                list[indexOfMin] = list[i];
                list[i] = min;
            }
        }
    }
}
