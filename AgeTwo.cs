using System;

class AgeTwo
{
   static void Main(string[] args) 
   {
      int age;

      Console.Write("\nEnter your age:> ");
      age = Convert.ToInt32(Console.ReadLine());
     
      if (age >= 18)
         Console.Write("You can vote.\n");
      else
         Console.Write("You are too young to vote.\n");
   }
}