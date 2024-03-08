using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Return_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            JudgeCircle("UD");
        }
        public static bool JudgeCircle(string moves)
        {
            int[] U = {0,1};
            int[] D = {0,-1};
            int[] R = {1,0};
            int[] L = {-1,0};
            int[] move = { 0, 0 };
            int[] origin = { 0, 0 };
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'U')
                {
                    move[0] += U[0];
                    move[1] += U[1];

                }
                if (moves[i] == 'D')
                {
                    move[0] += D[0];
                    move[1] += D[1];
                }
                if (moves[i] == 'R')
                {
                    move[0] += R[0];
                    move[1] += R[1];
                }
                if (moves[i] == 'L')
                {
                    move[0] += L[0];
                    move[1] += L[1];
                }
            }
            if (move[0] == origin[0])
            {
                if(move[1] == origin[1])
                {
                return true;
                    
                }
            }
            else
            {
                return false;
            }
            return false;
        }
    }
}
