using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Number_of_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueOccurrences( new int[] {1,2,2,1,1,3});
        }
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> hgh = new Dictionary<int, int>();
            //derive keys , if value == key then increment that value to the key
            HashSet<int> keys = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            { 
            keys.Add(arr[i]);
            }
            for (int i = 0; i < keys.Count; i++)
            {
                hgh.Add(keys.ElementAt(i), 0);
            }

            for(int i=0;i<arr.Length;i++)
            {
                if (hgh.ContainsKey(arr[i]))
                {
                    hgh[arr[i]]+=1;
                }
            }
            int[] a = new int[keys.Count];
            for (int i = 0; i < hgh.Count; i++)
            {
                a[i]=hgh[keys.ElementAt(i)];
            }
            HashSet<int> fi = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                fi.Add(a[i]);
            }
            int A = fi.Count;
            int B = a.Length;
            if (A == B)
            {
                return true;
            }
            
            
        return false;
        }
    }
}
