using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleNumber(new int[] {4, 1, 2, 1, 2});
        }
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int x=0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;++i)
            {

                if (dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] += 1;
                }
                else
                {
                    dic.Add(nums[i], 1);
                }
            }
            for (int i = 0; i < dic.Count; ++i)
            {
                if (dic.ElementAt(i).Value == 1)
                {
                    return dic.ElementAt(i).Key;
                }

                    


            
            }
            return 0;
        }
    }
}
