using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Highest_Altitude2
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestAltitude(new int[] { -5, 1, 5, 0, -7 });
        }
        public static int LargestAltitude(int[] gain)
        {
            List<int> lengths = new List<int>();
            int x = 0;
            lengths.Add(x);
            for (int i = 0; i < gain.Length; ++i)
            {
                x = x + gain[i];
                lengths.Add(x);
            }
            int y = 0;
            for(int i=0;i<lengths.Count;++i)
            {
                if (y < lengths[i])
                {
                    y = lengths[i];
                } 
            }
            return y;
        }
    }
}
