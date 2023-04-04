namespace DataStructures
{
    public class MyList
    {
        private int MaxSize = 5;
        private int End { get; set; }
        private int[] Arr { get; set; }

        public MyList()
        {
            Arr = new int[MaxSize];
            End = -1;
        }

        public bool IsEmpty()
        {
            return End == -1;
        }

        public int Count()
        {
            return End == -1 ? 0 : End + 1;
        }
        public void Fill(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {
                this.Add(i);
            }
        }
        public void Add(int item)
        {
            if ((End + 1) != MaxSize)
            {
                Arr[++End] = item;
            }
            else
            {
                MaxSize *= 2;
                int[] NewArr = new int[MaxSize];

                Array.Copy(Arr, NewArr, End);
                //for(int i = 0; i <= End; i++)
                //    NewArr[i] = Arr[i];

                Arr = NewArr;
                Arr[++End] = item;

                GC.Collect();
            }
        }
        public void InsertAt(int item, int index)
        {
            for (int i = ++End; i > index; i--)
            {
                Arr[i] = Arr[i - 1];
            }
            Arr[index] = item;
        }
        public void ReamoveAt(int index)
        {
            for(int i = index; i < End; i++)
            {
                Arr[i] = Arr[i+1];
            }
            Arr[End--] = 0;
        }
        public void EditItem(int newValue, int index)
        {
            Arr[index] = newValue;
        }
        public void Print(bool oneLine=false)
        {
            if (!oneLine)
                for (int i = 0; i <= End; i++)
                {
                    Console.WriteLine(Arr[i]);
                }
            else
            {
                for (int i = 0; i <= End; i++)
                {
                    Console.Write(Arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            string resualt = "";
            for (int i = 0; i <= End; i++)
            {
                resualt += Arr[i] + " ";
            }
            resualt += "\n";
            return resualt;
        }

    }
}