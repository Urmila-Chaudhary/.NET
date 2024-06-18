namespace MultiDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MDelegate m1= new MDelegate(MultDelg.Display);
            MDelegate m2 = new MDelegate(MultDelg.Print);
            MDelegate m3 = m1 + m2;
            MDelegate m4 = m2 - m1;
            MDelegate m5 = m3 - m2;

            m3();
            m4();
            m5();

        }
    }
}
