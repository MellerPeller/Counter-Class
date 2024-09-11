namespace Counter_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter(3);
            counter.Increment();
            counter.Increment();
            counter.Increment();  
            Console.WriteLine("counter: " + counter.GetValue());
            counter.Reset();
            Console.WriteLine("counter: " + counter.GetValue());
            counter.Incrementby(20);
            Console.WriteLine("counter: " + counter.GetValue());

        }
    }
}
