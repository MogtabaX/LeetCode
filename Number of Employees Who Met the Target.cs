using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Employees_Who_Met_the_Target
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int x = 0;
            int l = hours.Length;

            for (int i = 0; i < l; ++i)
            {
                if (hours[i] >= target)
                {
                    ++x;
                }
            }
            return x;
        }
    }
}
