namespace DataStructures
{
    public class MyList
    {
        private int MaxSize = 10;
        public int End { get; set; }
        private int[] Arr { get; set; }

        public MyList()
        {
            Arr = new int[MaxSize];
            End = -1;
        }
        private MyList(int size, int end)
        {
            Arr = new int[size];
            End = end;
        }

        public bool IsEmpty()
        {
            return End == -1;
        }

        public int Count()
        {
            return End == -1 ? 0 : End + 1;
        }
        public void Add(int i)
        {
            if ((End + 1) != MaxSize)
            {
                End++;
                Arr[End] = i;
            }
            else
            {
                var NewArr = new MyList(MaxSize * 2, End);
                //TDOD:.... 
                Console.WriteLine("Arrived max size");
            }
        }
        public void Print()
        {
            for (int i = 0; i <= End; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }

        public void ReamoveAt(int index)
        {
            for(int i = index; i < End; i++)
            {
                Arr[i] = Arr[i+1];
            }
            Arr[End] = 0;
            End--;
        }
    }
}