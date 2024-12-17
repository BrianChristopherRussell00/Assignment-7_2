using System;

namespace Assignment_7_2
{
    internal class Program
    {
        private static int[] newarr;
        private static string arr;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an array of your choice using numbers followed by a space between each:");//Assignment 7.2 Part 1
            string userInput = Console.ReadLine();
            string[] userArray = userInput.Split(' ');
            int[] inputArray = userArray.Select(int.Parse).ToArray();

            //Display original array
            Console.WriteLine($"Your original array is: [{string.Join(", ", inputArray)}]");

            //Calling the Sort method
            SortingNumbers.Sort(inputArray);

            //Display new sorted array
            Console.WriteLine($"Your sorted array is: [{string.Join(", ", inputArray)}]");




            // string input1 = "hello"; //Assignment 7.2 Part 2
            //  string output1 = FindVowels.ReverseVowels(input1);
            // Console.WriteLine($"Input : {input1}\nOutput: {output1}");

            //     string input2 = "avacado";
            //    string output2 = FindVowels.ReverseVowels(input2);
            //   Console.WriteLine($"Input : {input2}\nOutput: {output2}");





            string string1 = "anagram";   // Assignment 7.2 Part 3
            string string2 = "nagaram";
            Console.WriteLine($"{string1} and {string2} {Anagram.isAnagram(string1, string2)}");
        }
    }
}