using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGame(new int[] {5,4,2,3});
        }
        public static int[] NumberGame(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int min = 0;
            int x = 0;
            int index = 0;

                for (int j = 0; j < nums.Length; ++j)
                {
                    min = 0;
                    for (int i = 0; i < nums.Length; ++i)
                    {
                        if (nums[i] > min)
                        {
                            min = nums[i];
                        }
                    }
                    for (x = 0; x < nums.Length; ++x)
                    {

                        if (nums[x] < min && nums[x]!=0)
                        {
                            min = nums[x];
                            index = x;
                        }
                    }
                    nums[index] = 0;
                    arr[j] = min;
                }
                int temp = 0;
                for (int i = 0; i < arr.Length-1; i+=2)
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            return arr;
        }
    }
}
