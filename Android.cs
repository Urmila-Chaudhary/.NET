using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
#inheritance
namespace MobileApplication
{
    public class Android : Mobile

    {
        public String osVersion;
        public Android(String brand, String model, String osVersion):base(brand,model)
        {
            this.osVersion = osVersion;
        }
        
        public void PrintDetails()
        {
            Console.WriteLine("Brand: " + base.brand);
            Console.WriteLine("Model: " + base.model);
            Console.WriteLine("Battery level: " + base.batteryLevel);
            Console.WriteLine("OS Version: "+ osVersion);
        }
    }
}
