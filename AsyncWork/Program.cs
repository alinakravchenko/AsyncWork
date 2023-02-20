namespace AsyncWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WaitCallback callback = new WaitCallback(Sum);
                //ThreadPool.SetMaxThreads(1, 1);
                
            for (int i = 0; i <= 20; i++)
            {
            ThreadPool.QueueUserWorkItem(callback,i* 10000);      //коллекция множества потоков, объединенные одной задачей

            }
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
        static void Sum(object count)
        {

            int result = 0;
            for (int i = 0; i < (int)count; i++)
            {
                result += i;
            }
            //Console.WriteLine("Кол-во потоков: " + ThreadPool.ThreadCount);
            Console.WriteLine("Thread Number: " +Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(result);
        }
    }
}