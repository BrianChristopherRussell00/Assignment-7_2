using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_7_2
{
    public class Anagram
    {
        public static bool isAnagram(string s, string t)
        {
            char[] string1 = s.ToCharArray();
            char[] string2 = t.ToCharArray();

            Array.Sort(string1);
            Array.Sort(string2);

            if (string1.Length == string2.Length)
            {
                for (int i = 0; i <= string1.Length - 1; i++)
                {
                    if (string1[i] != string2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}