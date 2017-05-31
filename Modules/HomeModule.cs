using Nancy;
using PalindromeProject.Objects;
using System.Collections.Generic;

namespace PalindromeProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Palindrome newPalindrome = new Palindrome(Request.Form["input"]);
        string userInput = newPalindrome.GetInitialInput();
        string output = Palindrome.CheckPalindrome(userInput);
        return View["index.cshtml", output];
      };
    }
  }
}
