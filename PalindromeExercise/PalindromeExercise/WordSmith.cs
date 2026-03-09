using System.Linq;
using System;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return false;
            
        }
        // get string and convert to lowercase and remove non-alphanumeric characters 
        string normalized = new string(word.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        
        // reverse string 
        char[] charArray = normalized.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        
        // compare original to reversed string 
        return normalized.Equals(reversed);
    }
    
}