using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Digits
{
    class Program
    {

        public static int AddDigits(int num)
        {
         
            while (num > 9)
            {
                //num to string
                string Dig = num.ToString();
                //dig to array
                char[] DigAr = new char[Dig.Length];
                for (int i = 0; i < DigAr.Length; i++)
                {
                    DigAr[i] = Dig[i];
                }
                //DigAr to int array
                int[] DigArInt = new int[Dig.Length];
                for (int i = 0; i < DigArInt.Length; i++)
                {
                    DigArInt[i] = (int)char.GetNumericValue(Dig[i]);
                }
                //DigArInt to SumDigArInt
                int sum = 0;
                for (int i = 0; i < DigArInt.Length; i++)
                {
                    sum += DigArInt[i];
                    num = sum;
                }
            }
              
            return num;
        }        
        static void Main(string[] args)
        {
            AddDigits(38);
        }

       
    }
}
