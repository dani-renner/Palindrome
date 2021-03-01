using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Test{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsUserWord_Palindrome()
    {
      SameBothWays testPalindrome = new SameBothWays();
      Assert.AreEqual(true, testPalindrome.WordReverse("racecar"));
    }
  }
}