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
    public static bool CheckPalindrome(string userInput)
    {
      string input = userInput;
      char[] arrayInput = input.ToCharArray();
      Array.Reverse(arrayInput);
      string output = string.Join("", arrayInput);
      Console.WriteLine(output);

      if (userInput == output)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
