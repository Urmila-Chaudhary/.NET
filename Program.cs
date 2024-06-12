namespace MobileApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Mobile obj = new Mobile("Samsung","S22");
            Console.WriteLine("Enter mobile no: ");
            String mobNo = Console.ReadLine();
            obj.MakeCall(mobNo);
            Console.WriteLine("Enter charging amount: ");
            int charge = int.Parse(Console.ReadLine());
            obj.ChargeBattery(charge);
            Console.WriteLine("Enter usage amount: ");
            int use = int.Parse(Console.ReadLine());
            obj.UseBattery(use);
            obj.PrintDetails();
            */
            Android child = new Android("iPhone","Pro15","10");
            Console.WriteLine("Enter mobile no: ");
            String mobNo = Console.ReadLine();
            child.MakeCall(mobNo);
            Console.WriteLine("Enter charging amount: ");
            int charge = int.Parse(Console.ReadLine());
            child.ChargeBattery(charge);
            Console.WriteLine("Enter usage amount: ");
            int use = int.Parse(Console.ReadLine());
            child.UseBattery(use);
            child.PrintDetails();
        }
    }
}
