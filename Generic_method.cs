namespace Generic_method
{
    internal class Program
    {
        public void Add<T>(T a , T b)
        {
            dynamic x = a;//dynamic can take any datatype
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine($"Result of adding {a} and {b} : {sum}");
        }
        static void Main(string[] args)
        {
            int x = 10; int y = 20;
            Console.WriteLine($"Before calling Add Method: x = {x} and y = {y}");
            Program obj = new Program();
            obj.Add(x,y);//calling add method with in parameters...unboxing happens
            //Console.WriteLine($"After calling Add Method: x = {x} and y = {y}");
            Console.WriteLine();

            string s1 = "Virat";
            string s2 = " Kohli";
            Console.WriteLine($"Before calling Add Method: s1 = {s1} and s2 = {s2}");
            obj.Add(s1,s2);
        }
    }
}
