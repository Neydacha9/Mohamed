using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
    internal interface ICalc1
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int num3 { get; set; }
        public int addition(int num1, int num2);
        public int substraction(int num1, int num2);
        public int division(int num1, int num2);
        public int multiplication(int num1, int num2);
    }
}
