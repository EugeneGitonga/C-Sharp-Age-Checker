using System;

class AgeOne
{
   static void Main(string[] args) 
   {
      int age;

      Console.Write("\nEnter your age:> ");
      age = Convert.ToInt32(Console.ReadLine());
     
      if (age >= 18)
         Console.Write("You can vote.\n");
   }
}