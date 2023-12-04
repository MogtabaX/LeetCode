using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_Difference_of_Two_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            FindDifference(new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2 });
        }
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            int x=0;
            int y = 0;
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                { 
                    if(nums1[i]!=nums2[j])
                    {
                        x++;
                    }
                    if (x == nums2.Length)
                    {
                        a.Add(nums1[i]);
                        x = 0;
                    }
                }
                x = 0;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums2[i] != nums1[j])
                    {
                        y++;
                    }
                    if (y == nums1.Length)
                    {
                        b.Add(nums2[i]);
                        y = 0;
                    }
                }
                y = 0;
            }
            List<int> l1 = new List<int>();
            List<int> l2 = new List<int>();

            for (int i = 0; i < a.Count; i++)
            {
                l1.Add(a.ElementAt(i));
            }
            for (int i = 0; i < b.Count; i++)
            {
                l2.Add(b.ElementAt(i));
            }
            List<List<int>> answer = new List<List<int>>();
            answer.Add(l1);
            answer.Add(l2);
            return answer.ToArray();
        }
    }
}
