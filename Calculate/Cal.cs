using Calculate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    internal class Cal : ICal
    {
        public string num1 { get; set; }
        public string num2 { get; set; }
        public int addition(int num1,  int num2)
        {
            return num1 + num2;
        }
        public int subtraction(int num1, int num2) 
        {
            return num1 - num2;
        }
        public int division(int num1, int num2)
        {
            return num1 / num2;
        }
        public int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
