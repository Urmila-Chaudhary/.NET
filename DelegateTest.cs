namespace delegates
{
    
    internal class DelegateTest
    {
       

        static void Main(string[] args)
        {
            ArithOp op1 = new ArithOp(MathOperation.Add);
            ArithOp op2 = new ArithOp(MathOperation.Sub);

            int result1 = op1(200, 100);
            int result2 = op2(200, 100);
            Console.WriteLine(" Sum = "+ result1);
            Console.WriteLine(" Difference = " + result2);

        }
    }
}
