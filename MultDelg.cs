using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegate
{
    delegate void MDelegate();
    internal class MultDelg
    {
        public static void Display()
        {
            Console.WriteLine("Banglore");
        }
        public static void Print()
        {
            Console.WriteLine("Delhi");
        }
    }
}
