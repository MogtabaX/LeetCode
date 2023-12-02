using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_the_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            convertTemperature(55);
        }
        public static double[] convertTemperature(double celsius)
        {
            double[] ans = new double[2];
            ans[0] = celsius + 273.15;
            ans[1] = celsius * 1.80 + 32.00;
            return ans;
        }
    }
}
