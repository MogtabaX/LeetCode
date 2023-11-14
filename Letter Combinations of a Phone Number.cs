using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Combinations_of_a_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterCombinations("234");

        }
        public static IList<string> LetterCombinations(string digits)
        {
            List<string> dig = new List<string>();
            List<string> output = new List<string>();
            for (int i = 0; i < digits.Length; i++)
            {
                dig.Add(digits.ElementAt(i).ToString());
            }
            string[] alpha = new string[dig.Count];
            for (int i = 0; i < digits.Length; i++)
            {
                if (dig[i] == "0")
                    alpha[i] = "";
                else if (dig[i] == "1")
                    alpha[i]="";
                else if (dig[i] == "2")
                    alpha[i]="abc";
                else if (dig[i] == "3")
                    alpha[i]="def";
                else if (dig[i] == "4")
                    alpha[i]="ghi";
                else if (dig[i] == "5")
                    alpha[i]="jkl";
                else if (dig[i] == "6")
                    alpha[i]="mno";
                else if (dig[i] == "7")
                    alpha[i]="pqrs";
                else if (dig[i] == "8")
                    alpha[i]="tuv";
                else if (dig[i] == "9")
                    alpha[i]="wxyz";
            
            }
            
            if (digits.Length == 1)
            {
                for(int i=0; i<alpha.Length;i++)
                output.Add(alpha[0].ElementAt(i).ToString());
            }
            else if (digits.Length==2)
            {
                for (int i = 0; i < alpha.Length - 1; i++)
                {
                    for (int x = 0; x < alpha[i].Length; x++)
                    {
                        for (int y = 0; y < alpha[i+1].Length; y++)
                        {
                            output.Add(alpha[i].ElementAt(x).ToString() + alpha[i + 1].ElementAt(y).ToString());
                        }

                    }
                    break;
                } 
            }
            else if (digits.Length == 3)
            {
                for (int i = 0; i < alpha.Length - 1; i++)
                {
                    for (int x = 0; x < alpha[i].Length; x++)
                    {
                        for (int y = 0; y < alpha[i+1].Length; y++)
                        {
                            for(int z = 0; z<alpha[i+2].Length;z++)
                            {
                            output.Add(alpha[i].ElementAt(x).ToString() + alpha[i+1].ElementAt(y).ToString() + alpha[i+2].ElementAt(z).ToString()); 
                            }
                        }

                    }
                    break;
                }
            }
            else if (digits.Length == 4)
            {
                for (int i = 0; i < alpha.Length - 1; i++)
                {
                    for (int x = 0; x < alpha[i].Length; x++)
                    {
                        for (int y = 0; y < alpha[1].Length; y++)
                        {
                            for (int z = 0; z < alpha[2].Length; z++)
                            {
                                for (int h = 0; h < alpha[3].Length; h++)
                                {
                                    output.Add(alpha[i].ElementAt(x).ToString() + alpha[i+1].ElementAt(y).ToString() + alpha[i+2].ElementAt(z).ToString() + alpha[i+3].ElementAt(h).ToString());
                                }

                            }
                        }

                    }
                    break;
                }
            }                    
            return output;

}            
}








        }
    

