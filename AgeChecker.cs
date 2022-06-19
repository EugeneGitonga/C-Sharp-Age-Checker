using System;

class AgeChecker
{
   static void Main(string[] args) 
   {
      int theAge;

      Console.Write("\nEnter your age -> ");
      theAge = Convert.ToInt32(Console.ReadLine());
      
      if (theAge < 13)
         Console.Write("Hello Child\n");
      else if (theAge < 20)
         Console.Write("Hello Teenager\n");
      else if (theAge < 35)
         Console.Write("Hi there young adult\n");
      else
         Console.Write("Hello there elder\n");
   }
}