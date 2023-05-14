using HTU.DSAlgo.DataStructures;

namespace HTU.DSAlgo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var queue = new MyQueue<int>();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            Console.WriteLine(queue.Front.Data); // 1
            Console.WriteLine(queue.Rear.Data); // 3
            queue.DeQueue();
            Console.WriteLine("========");
            Console.WriteLine(queue.Front.Data); // 2
            Console.WriteLine(queue.Rear.Data); // 3
        }
        static int Factorial(int x)
        {
            if (x <= 1) return 1;
            return x * Factorial(x-1);
        }

        static int LoopFactorial(int x)
        {
            int fact = 1;
            for (int i = x; i > 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
        static int Fibonacci(int x)
        {
            if (x <= 2) return 1;
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
        static int LoopFibonacci(int x)
        {
            int f  = 0;
            int f0 = 0;
            int f1 = 1;

            for (int i = 2; i <= x; i++)
            {
                f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            return f;
        }



























        static int RecursivSum(List<object> nestedList)
        {
            int sum = 0;
            foreach (var item in nestedList)
            {
                if (item is int)
                {
                    // If item is an integer, add it to the sum
                    sum += (int)item;
                }
                else if (item is List<object>)
                {
                    // If item is a list, recursively call CalculateSum to get the sum of its elements
                    sum += RecursivSum((List<object>)item);
                }
            }
            return sum;

        }
    }
}
