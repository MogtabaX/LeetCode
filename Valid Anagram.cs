using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAnagram("aaccr", "ccaai");
        }
        public static bool IsAnagram(string s, string t)
        {
            if (t.Length > s.Length || s.Length > t.Length)
            {
                return false;
            }
            char[] ScharArray = s.ToCharArray();
            char[] TcharArray = t.ToCharArray();
            Array.Sort(ScharArray);
            Array.Sort(TcharArray);
            string A = "";
            string B = "";
            for (int i = 0; i < ScharArray.Length; i++)
            {
                A += ScharArray[i].ToString();
            }
            for (int i = 0; i < TcharArray.Length; i++)
            {
                B += TcharArray[i].ToString();
            }
            if (A == B)
            {
                return true;
            }
            else
                return false;
            /*
            char temp='';
            for (int i = 0; i < s.Length; i++)
            { 
                for(int j=i+1; j<s.Length;j++)
                {
                    if(s[i]>s[j])
                    {
                        temp=s[i];
                        s[i]=s[j];
                        s[j]=temp;
                    }
                }
                
            }
             */
                /*
            char[] A = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                A[i]=(s.ElementAt(i));
            }
            Array.Sort(A);
            char[] B = new char[t.Length];
            for (int i = 0; i < t.Length; i++)
            {
               B[i]=(t.ElementAt(i));
            }
            Array.Sort(B);

            string ss = "";
            string tt = "";
            for (int i = 0; i < A.Length; i++)
            {
                ss += A.ElementAt(i);
            }
            for (int i = 0; i < B.Length; i++)
            {
                tt += B.ElementAt(i);
            }
            if (tt == ss)
                return true;
            else
                return false;
                 */

            //hash it . sort it . compare it
            /*HashSet<char> ss = new HashSet<char>();
            HashSet<char> tt = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                ss.Add (s[i]);
            }
            for (int i = 0; i < t.Length; i++)
            {
                tt.Add(t[i]);
            }
            ////////////

            char[] g = new char[ss.Count];
            SortedSet<char> sortS = new SortedSet<char>();
            SortedSet<char> sortT = new SortedSet<char>();

            for (int i = 0; i < ss.Count; i++)
            {
                sortS.Add(ss.ElementAt(i));
            }
            for (int i = 0; i < tt.Count; i++)
            {
                sortT.Add(tt.ElementAt(i));
            }
            /////////////////
            string newS = "";
            string newT = "";
            for (int i = 0; i < sortS.Count; i++)
            {
                newS += sortS.ElementAt(i);
            }
            for (int i = 0; i < sortT.Count; i++)
            {
                newT += sortT.ElementAt(i);
            }
            //////////////////
            if (newS == newT)
            {
                return true;
            }
            else
            {
                return false;
            }
            return false;*/
        }
    }
}
