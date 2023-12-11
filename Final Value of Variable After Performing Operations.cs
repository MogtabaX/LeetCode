using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Value_of_Variable_After_Performing_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            FinalValueAfterOperations(new string[]{"X++","++X","--X","X--"});
        }
        public static int FinalValueAfterOperations(string[] operations)
        {
            int x = 0;

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "++X" || operations[i] == "X++")
                    x++;
                else if (operations[i] == "--X" || operations[i] == "X--")
                    x--;
            }
            return x;
        }
    }
}
