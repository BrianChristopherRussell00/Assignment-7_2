using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_2
{
    public class PrintArray
    {
       public static void printArrays(int[] newarr, int answer)
        {
            int[] n= new int[answer];  
            for (int i = 0; i < n.Length; ++i)
                Console.Write(newarr[i] + " ");
            Console.WriteLine();
        }
       public static int sort(int[] newarr,int answer)
        {
            int[] n = new int[answer];

            // Start with a big gap, 
            // then reduce the gap
            for (int gap = n.Length / 2; gap > 0; gap /= 2)
            {
                // Do a gapped insertion sort for this gap size.
                // The first gap elements a[0..gap-1] are already
                // in gapped order keep adding one more element
                // until the entire array is gap sorted
                for (int i = gap; i < n.Length; i += 1)
                {
                    // add a[i] to the elements that have
                    // been gap sorted save a[i] in temp and
                    // make a hole at position i
                    int temp = newarr[i];

                    // shift earlier gap-sorted elements up until
                    // the correct location for a[i] is found
                    int j;
                    for (j = i; j >= gap && newarr[j - gap] > temp; j -= gap)
                        newarr[j] = newarr[j - gap];

                    // put temp (the original a[i]) 
                    // in its correct location
                   newarr[j] = temp;
                }
            }
            return 0;
        }


    }
}
