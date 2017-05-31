using Xunit;
using System.Collections.Generic;

namespace PalindromeProject.Objects
{
  public class PalindromeTest
  {
    [Fact]
    public void CheckPalindrome_ReverseUserInput_true()
    {
      //Arrange
      string userInput = "racecar";
      Palindrome instance = new Palindrome(userInput);

      //Act
      string result = instance.GetInitialInput();

      //Assert
      Assert.Equal(true, Palindrome.CheckPalindrome(result));
    }

    [Fact]
    public void CheckPalindrome_MatchUserInput_true()
    {
      //Arrange
      string userInput = "racecar";
      Palindrome instance = new Palindrome(userInput);

      //Act
      string result = instance.GetInitialInput();

      //Assert
      Assert.Equal(true, Palindrome.CheckPalindrome(result));
    }

  }
}
