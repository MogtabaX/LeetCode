using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        public static void Main()
        {
            RemoveDuplicates(new int[] { 0, 0, 1,1,1,1,1,2,2,3,3,4 });

        }
        public static int RemoveDuplicates(int[] nums)
        {
            List<int> list = new List<int>();
            list.Add(nums[0]);
            for (int step = 1; step < nums.Length; step++)
            {
                if (nums[step] != nums[step - 1])

                    list.Add(nums[step]);
            }


            for (int i = 0; i < list.Count; i++)
            {
                nums[i] = list[i];
                Console.WriteLine(nums[i]);
            }
            int k = list.Count;
            return k;

        }
    }
}
