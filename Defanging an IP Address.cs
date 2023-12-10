using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defanging_an_IP_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            DefangIPaddr("1.1.1.1");
        }
        public static string DefangIPaddr(string address)
        {
            string result = "";

            for (int i = 0; i < address.Length; i++)
            {
                if (address[i] != '.')
                {
                    result += address[i];
                }
                else if (address[i] == '.')
                {
                    result += '[' + address[i].ToString() + ']';
                }

            }
            return result;
        }
    }
}
