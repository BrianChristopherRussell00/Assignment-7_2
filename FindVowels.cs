using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_2
{
    public class FindVowels
    {
        public static string ReverseVowels(string s)
        {
            char[] charArray = s.ToCharArray();
            int start = 0;
            int end = charArray.Length - 1;
            string vowels = "aeiouAEIOU";
            while (start < end)
            {
                if (!vowels.Contains(charArray[start]))
                {
                    start++;
                    continue;
                }
                if (!vowels.Contains(charArray[end]))
                {
                    end--;
                    continue;
                }
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++;
                end--;

            }
            return new string(charArray);
        }
    }
}

