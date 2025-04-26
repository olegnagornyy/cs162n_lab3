using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = UserInput();
            Console.WriteLine($"Is palindrome: {IsPalindrome(word)}");
        }
        static string UserInput()
        {
            Console.Write("Enter a string to check for palindrome: ");
            return Console.ReadLine();
        }

        static bool IsPalindrome(string word)
        {
            if (word == "" || word.Length == 1) return true;
            if (word[0] == word[^1])
            {
                return IsPalindrome(word.Substring(1, word.Length - 2));
            }
            return false;
        }
    }
}
