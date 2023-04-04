namespace DataStructures
{
    public class MyList
    {
        private int _maxSize = 5;
        private int _End { get; set; }
        private int[] _arr { get; set; }

        public MyList()
        {
            _arr = new int[_maxSize];
            _End = -1;
        }

        public bool IsEmpty()
        {
            return _End == -1;
        }

        public int Count()
        {
            return _End == -1 ? 0 : _End + 1;
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
            if ((_End + 1) != _maxSize)
            {
                _arr[++_End] = item;
            }
            else
            {
                _maxSize *= 2;
                int[] NewArr = new int[_maxSize];

                Array.Copy(_arr, NewArr, _End);
                //for(int i = 0; i <= End; i++)
                //    NewArr[i] = Arr[i];

                _arr = NewArr;
                _arr[++_End] = item;

                GC.Collect();
            }
        }
        public void InsertAt(int item, int index)
        {
            for (int i = ++_End; i > index; i--)
            {
                _arr[i] = _arr[i - 1];
            }
            _arr[index] = item;
        }
        public void ReamoveAt(int index)
        {
            for(int i = index; i < _End; i++)
            {
                _arr[i] = _arr[i+1];
            }
            _arr[_End--] = 0;
        }
        public void EditItem(int newValue, int index)
        {
            _arr[index] = newValue;
        }
        public void Print(bool oneLine=false)
        {
            if (!oneLine)
                for (int i = 0; i <= _End; i++)
                {
                    Console.WriteLine(_arr[i]);
                }
            else
            {
                for (int i = 0; i <= _End; i++)
                {
                    Console.Write(_arr[i] + " ");
                }
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            string resualt = "";
            for (int i = 0; i <= _End; i++)
            {
                resualt += _arr[i] + " ";
            }
            resualt += "\n";
            return resualt;
        }

    }
}