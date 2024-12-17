using System;

namespace Assignment_7_2
{
    internal class Program
    {
        private static int[] newarr;
        private static string arr;

        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers are you including?");
            int answer = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < answer; i++)
            {

                Console.WriteLine("Enter array numbers: ");
                string arr = Console.ReadLine();
                int[] newarr = Array.ConvertAll(arr.Split(','), int.Parse);
            }


            Console.Write("Array before sorting :\n");
            PrintArray.printArrays(newarr, answer);


            PrintArray.sort(newarr, answer);

            Console.Write("Array after sorting :\n");
            PrintArray.printArrays(newarr, answer);                //Assignment 7.2 Part 1

            string input1 = "hello"; //Assignment 7.2 Part 2
            string output1 = FindVowels.ReverseVowels(input1);
            Console.WriteLine($"Input : {input1}\nOutput: {output1}");

            string input2 = "avacado";
            string output2 = FindVowels.ReverseVowels(input2);
            Console.WriteLine($"Input : {input2}\nOutput: {output2}");





            string string1 = "anagram";   // Assignment 7.2 Part 3
            string string2 = "nagaram";
            Console.WriteLine($"{string1} and {string2} {Anagram.isAnagram(string1,string2)}");
        }
    }
}
