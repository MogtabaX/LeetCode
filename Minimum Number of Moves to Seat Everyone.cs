using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number_of_Moves_to_Seat_Everyone
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMovesToSeat(new int[] { 12, 14, 19, 19, 12 }, new int[] { 19, 2, 17, 20, 7 });
        }
        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            int[] ar1 = seats.ToArray();
            int[] ar2 = students.ToArray();
            int temp = 0;
            try
            {
                for (int i = 0; i < ar1.Length; ++i)
                {
                    for (int j = i + 1; j < ar1.Length; ++j)
                    {
                        if (ar1[i] > ar1[j])
                        {
                            temp = ar1[j];
                            ar1[j] = ar1[i];
                            ar1[i] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            { 
            }
            temp = 0;
            try
            {
                for (int i = 0; i < ar2.Length; ++i)
                {
                    for (int j = i + 1; j < ar2.Length; ++j)
                    {
                        if (ar2[i] > ar2[j])
                        {
                            temp = ar2[j];
                            ar2[j] = ar2[i];
                            ar2[i] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
            }
            int result = 0;

            for (int i = 0; i < ar1.Length; ++i)
            {
                result += Math.Abs (ar1[i] - ar2[i]);
            }

            return result;
        }
    }
}
