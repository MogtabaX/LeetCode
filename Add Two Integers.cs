using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Two_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 10);
        }
        public static int Sum(int num1, int num2)
        {
            return ((sbyte)num1 + (sbyte)num2);  
        }
    }
}
