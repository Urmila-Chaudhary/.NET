namespace Generic_delegates
{
    internal class Program
    {
        public delegate int SumDeligate(int x, int y);

        static void Main(string[] args)
        {
            SumDeligate sd1 = delegate(int x , int y) { return x + y; };
            Console.WriteLine($"Upon calling the anonymous function using delegate, Sum: {sd1(18,2)}");
        }
    }
}
