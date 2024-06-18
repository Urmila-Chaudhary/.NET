namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Books b1 = new Books("Pride & Prejuidice","Jane Austen");
            b1.PrintDetails();
            Books b2 = new Books(20, "Penguin House");
            b2.PrintPubDetails();
        }
    }
}
