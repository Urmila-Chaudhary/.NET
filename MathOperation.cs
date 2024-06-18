using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates

{
    delegate int ArithOp(int x, int y);
    internal class MathOperation
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }

        public static int Sub(int a, int b)
        {
            return (a - b);
        }
    }
}
