# Palindrome Checker

#### A program that allows users to input a word or phrase to determine if it is a palindrome. 5/31/17

#### By **Marilyn Carlin and Jared Luedtke**

## Description

A website created with C#, HTML, and CSS where a user can submit a word or phrase to determine whether or not it is a palindrome.


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Homepage** | User accesses localhost:5004 | Homepage with user input form |
| **Program Gathers User Input** | User input: "racecar" | Output: "racecar" |
| **Program Removes Spaces From User Input**| User Input: "Lisa Bonet ate no basil" | Output: "LisaBonetatenobasil" |
| **Program Reverses User Input**| Input: "LisaBonetatenobasil" | Output: "lisabonetatenoBasiL" |
| **Program Compares Inputs** | "LisaBonetatenobasil" vs. "lisabonetatenoBasiL" | Page displays: "Yes that is a palindrome!" |

## Setup/Installation Requirements

1. To run this program, you must have a C# compiler. I use [Mono](http://www.mono-project.com).
2. Install the [Nancy](http://nancyfx.org/) framework to use the view engine. Follow the link for installation instructions.
3. Clone this repository.
4. Open the command line--I use PowerShell--and navigate into the repository. Use the command "dnx kestrel" to start the server.
5. On your browser, navigate to "localhost:5004" and enjoy!

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
  * Nancy framework
  * Razor View Engine
  * ASP.NET Kestrel HTTP server
  * xUnit

* HTML
* CSS
  * Bootstrap

## Support and contact details

_Email no one with any questions, comments, or concerns._

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2017 **_{Marilyn Carlin, Jared Luedtke}_**
