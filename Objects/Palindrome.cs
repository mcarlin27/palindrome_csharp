using System;
using System.Collections.Generic;

namespace PalindromeProject.Objects
{
  public class Palindrome
  {
    private string _initialInput;

    public Palindrome(string userInput)
    {
      _initialInput = userInput;
    }

    public string GetInitialInput()
    {
      return _initialInput;
    }
    public static string CheckPalindrome(string userInput)
    {
      string input = userInput;
      return input;
    }
  }
}
