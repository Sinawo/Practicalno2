using System;

namespace Problems
{
   public class Program
    {
        string Prifix(string input)
        {
                 int CountChars =0;

                 foreach(char s in input)CountChars++;
                 string[] found = input.Split(" ");
                 int words = found.Length;

                 
          return Convert.ToString(CountChars) + "," + Convert.ToString(words) +":"+input;

                
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
