using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    public class Car
    {
        public void Refonly(ref int num1, ref int num2)
        {
            num1++;
            num2++;
        }
        public void Refout(ref int num1, ref int result)
        {
            num1++;
            result = num1;
        }

    }
}