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
      string newInput = input.Replace(" ", "");
      Console.WriteLine(newInput);
      char[] arrayInput = newInput.ToCharArray();
      Array.Reverse(arrayInput);
      string output = string.Join("", arrayInput);

      if (newInput == output)
      {
        return "Yes, that's a palindrome!";
      }
      else
      {
        return "Nope, that's not a palindrome.";
      }
    }
  }
}
