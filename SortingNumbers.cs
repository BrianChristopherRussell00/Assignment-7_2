using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_2
{
    public class SortingNumbers
    {
        public static void Sort(int[] a)
        {

            // Start with half the array size, reduce by half each time
            for (int h = a.Length / 2; h > 0; h /= 2)
            {
                for (int i = h; i < a.Length; i++)  //Iterate over elements starting from 'h'
                {
                    int j = i;
                    int ai = a[i];

                    while (j >= h && a[j - h] > ai)
                    {
                        a[j] = a[j - h];
                        j -= h;  //Reduce index by h
                    }

                    a[j] = ai; //Place the temp value in its correct position
                }
            }
        }
    }
}
