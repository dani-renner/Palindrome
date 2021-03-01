namespace Palindrome
{
  public class SameBothWays
  {
    public bool IsPalidrome(string word)
    {

    char[] charArray = word.ToCharArray();
    charArray.Reverse( charArray );
      return charArray;
    }
  }
}