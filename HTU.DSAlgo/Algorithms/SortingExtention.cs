

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

        public static int[] MergeSort(this int[] arr)
        {
            int n = arr.Length;
            if (n < 2) return arr;

            int mid = n / 2;
            var leftArr = new int[mid];
            var rightArr = new int[n - mid];

            // Fill left array
            for (int i = 0; i < mid; i++)
            {
                leftArr[i] = arr[i];
            }

            // Fill right array
            for (int i = mid; i < n; i++)
            {
                rightArr[i - mid] = arr[i];
            }

            leftArr = leftArr.MergeSort();
            rightArr = rightArr.MergeSort();

            // Merge left and right arrays
            return leftArr.Merge(rightArr);
        }

        private static int[] Merge(this int[] leftArr, int[] rightArr)
        {
            int leftLen = leftArr.Length;
            int rightLen = rightArr.Length;
            int[] mergedArr = new int[leftLen + rightLen];
            int i = 0, j = 0, k = 0;

            // Merge with sorting
            while (i < leftLen && j < rightLen)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    mergedArr[k++] = leftArr[i++];
                }
                else
                {
                    mergedArr[k++] = rightArr[j++];
                }
            }

            // Copy remaining elements
            while (i < leftLen)
            {
                mergedArr[k++] = leftArr[i++];
            }

            while (j < rightLen)
            {
                mergedArr[k++] = rightArr[j++];
            }

            return mergedArr;
        }
    }
}
