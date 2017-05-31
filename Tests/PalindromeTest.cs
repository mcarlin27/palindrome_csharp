using Xunit;
using System.Collections.Generic;

namespace PalindromeProject.Objects
{
  public class PalindromeTest
  {
    [Fact]
    public void CheckPalindrome_GatherUserInput_true()
    {
      //Arrange
      string userInput = "racecar";
      Palindrome instance = new Palindrome(userInput);

      //Act

      //Assert
      Assert.Equal(userInput, Palindrome.CheckPalindrome(userInput));
    }
  }
}
