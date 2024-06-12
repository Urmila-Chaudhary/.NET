using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApplication
{
    public class Mobile
    {
        public String brand;
        public String model;
        public int batteryLevel;

        public Mobile(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
            this.batteryLevel = 0;
        }

        public void MakeCall(String mobNo)
        {
            Console.WriteLine("Calling "+mobNo+" ...");
            Console.WriteLine("Connected.\n");

        }

        public void ChargeBattery(int amount)
        {
            if (batteryLevel + amount < 100)
            {
                batteryLevel = batteryLevel + amount;
                Console.WriteLine("Battery: " + batteryLevel + "%\n");
            }
            else
            {
                batteryLevel = 100;
            }
            
        }

        public void UseBattery(int amount)
        {
            if(batteryLevel > 0)
            {
                batteryLevel = batteryLevel - amount;
                Console.WriteLine("Battery: " + batteryLevel + "%\n");
            }
            else
            {
                Console.WriteLine("No Charge...Charge your mobile!");
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Battery level: " + batteryLevel);
        }
    }
}
