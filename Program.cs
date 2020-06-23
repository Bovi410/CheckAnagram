using System;  
namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            char[] ch1 = word1.ToLower().ToCharArray();
            char[] ch2 = word2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine("These words are anagrams");
            }
            else
            {
                Console.WriteLine("These words arent anagrams");
            }

        }
    }
}