using System;
namespace Palindrome.Models
{
  public class SameBothWays
  {
    public bool WordReverse(string word)
    {
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    string reversedString = new string (charArray);
    return (reversedString == word);
    }
  }
} 