namespace HTU.DSAlgo.DataStructures.Lenear
{
    public class MyQueue<T>
    {
        public QNode<T> Front { get; set; }
        public QNode<T> Rear { get; set; }

        public MyQueue()
        {
            Front = null;
            Rear = null;
        }

        public void EnQueue(T item)
        {
            var newNode = new QNode<T> { Data = item };

            if (Front == null) // the queue is empty
            {
                Front = Rear = newNode;
                return;
            }

            Rear.Next = newNode;
            Rear = newNode;
        }

        public void DeQueue()
        {
            if (Front == null) return; // the queue is empty

            Front = Front.Next;

            if (Front == null) Rear = null; // the queue now is empty
        }
    }
    public class QNode<T>
    {
        public T Data;
        public QNode<T> Next;
    }
}
